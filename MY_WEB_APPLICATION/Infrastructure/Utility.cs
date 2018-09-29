using System.Linq;

namespace Infrastructure
{
	public static class Utility
	{
		static Utility()
		{
		}

		public static System.Linq.IOrderedQueryable<TSource> OrderBy<TSource>
			(this System.Collections.Generic.IEnumerable<TSource> query, string propertyName)
		{
			var entityType = typeof(TSource);

			//Create x => x.PropName
			var propertyInfo = entityType.GetProperty(propertyName);

			System.Linq.Expressions.ParameterExpression arg =
				System.Linq.Expressions.Expression.Parameter(entityType, "x");

			System.Linq.Expressions.MemberExpression property =
				System.Linq.Expressions.Expression.Property(arg, propertyName);

			var selector =
				System.Linq.Expressions.Expression.Lambda
				(property, new System.Linq.Expressions.ParameterExpression[] { arg });

			//Get System.Linq.Queryable.OrderBy() method.
			var enumarableType = typeof(System.Linq.Queryable);

			var method = enumarableType.GetMethods()
				 .Where(m => m.Name == "OrderBy" && m.IsGenericMethodDefinition)
				 .Where(m =>
				 {
					 var parameters = m.GetParameters().ToList();
					 //Put more restriction here to ensure selecting the right overload                
					 return parameters.Count == 2;//overload that has 2 parameters
				 }).Single();

			//The linq's OrderBy<TSource, TKey> has two generic types, which provided here
			System.Reflection.MethodInfo genericMethod =
				method.MakeGenericMethod(entityType, propertyInfo.PropertyType);

			//Call query.OrderBy(selector), with query and selector: x=> x.PropName
			//Note that we pass the selector as Expression to the method and we don't compile it.
			//By doing so EF can extract "order by" columns and generate SQL for it.*/
			var newQuery =
				(IOrderedQueryable<TSource>)
				genericMethod.Invoke(genericMethod, new object[] { query, selector });

			return newQuery;
		}

		public static System.Linq.IOrderedQueryable<TSource> OrderByDescending<TSource>
			(this System.Collections.Generic.IEnumerable<TSource> query, string propertyName)
		{
			var entityType = typeof(TSource);

			//Create x => x.PropName
			var propertyInfo = entityType.GetProperty(propertyName);

			System.Linq.Expressions.ParameterExpression arg =
				System.Linq.Expressions.Expression.Parameter(entityType, "x");

			System.Linq.Expressions.MemberExpression property =
				System.Linq.Expressions.Expression.Property(arg, propertyName);

			var selector =
				System.Linq.Expressions.Expression.Lambda
				(property, new System.Linq.Expressions.ParameterExpression[] { arg });

			//Get System.Linq.Queryable.OrderBy() method.
			var enumarableType = typeof(System.Linq.Queryable);

			var method = enumarableType.GetMethods()
				 .Where(m => m.Name == "OrderByDescending" && m.IsGenericMethodDefinition)
				 .Where(m =>
				 {
					 var parameters = m.GetParameters().ToList();
					 //Put more restriction here to ensure selecting the right overload                
					 return parameters.Count == 2;//overload that has 2 parameters
				 }).Single();

			//The linq's OrderBy<TSource, TKey> has two generic types, which provided here
			System.Reflection.MethodInfo genericMethod =
				method.MakeGenericMethod(entityType, propertyInfo.PropertyType);

			//Call query.OrderBy(selector), with query and selector: x=> x.PropName
			//Note that we pass the selector as Expression to the method and we don't compile it.
			//By doing so EF can extract "order by" columns and generate SQL for it.*/
			var newQuery =
				(IOrderedQueryable<TSource>)
				genericMethod.Invoke(genericMethod, new object[] { query, selector });

			return newQuery;
		}
	}
}
