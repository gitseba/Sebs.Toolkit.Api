namespace Sebs.Toolkit.Api.Abstractions
{
    /// <summary>
    /// Purpose:  Interface used for Models that will implement REST operations.
    /// REST operations with API. (Very useful in Web Api's)
    /// REST = GET/POST/PATCH/PUT/DELETE ...
    /// Created by: sebde
    /// Created at: 5/28/2023 10:04:21 PM
    /// </summary>
    /// <typeparam name="T"> RESPONSE: REST response object (e.g. HttpResponseMessage) </typeparam>
    /// <typeparam name="U"> REQUEST: REST Request object (e.g. DataModel) </typeparam>
    public interface IREST<T, U>
    {
        /// <summary>
        /// Get data based on id
        /// </summary>
        T GetById(int id);

        /// <summary>
        /// Get a list with all data
        /// </summary>
        T GetAll();

        /// <summary>
        /// Create new data
        /// </summary>
        T PostData(U newData);

        /// <summary>
        /// Update/Modify existing data. PATCH applies a partial update to the resource.
        /// you are only required to send the data that you want to update, and it won’t affect or change anything else.
        /// So if you want to update the first name on a database, you will only be required to send the first parameter;
        /// </summary>
        T PatchData(U updateData);

        /// <summary>
        /// Update/Replace existing data.PUT is a method of modifying resource where the client sends data that updates the entire resource. 
        /// It is used to set an entity’s information completely. 
        /// PUT is similar to POST in that it can create resources, but it does so when there is a defined URI. 
        /// PUT overwrites the entire entity if it already exists, and creates a new resource if it doesn’t exist.
        /// For example, when you want to change the first name of a person in a database, you need to send the entire resource when making a PUT request.
        /// </summary>
        T PutData(U updateData);

        /// <summary>
        /// Delete data
        /// </summary>
        T Delete(U deleteData);
    }
}
