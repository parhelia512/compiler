﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.5456
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ETH.Zonnon.Compute {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "2.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class ComputeKernelTemplates {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal ComputeKernelTemplates() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Compiler.Compute.ComputeKernelTemplates", typeof(ComputeKernelTemplates).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to /* all {expression}
        /// * check if all elements
        /// * result:
        /// *		0 - true for all elements
        /// *		1 - false for some elements
        /// */
        ///kernel void Kernel(
        ///		const ulong length{arguments}
        ///	)
        ///{
        ///	ulong id = get_global_id(0);
        ///
        ///#define Access(memory) memory[id]
        ///	bool value = {expression};
        ///#undef Access
        ///#define Access(memory) memory[0]
        ///	if (!value)
        ///		{target} = !value;
        ///#undef Access
        ///}.
        /// </summary>
        internal static string all {
            get {
                return ResourceManager.GetString("all", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to /* any {expression}
        /// * check if any element ...
        /// * result:
        /// *		1 - true for any element
        /// *		0 - false for all elements
        /// */
        ///kernel void Kernel(
        ///		const ulong length{arguments}
        ///	)
        ///{
        ///	ulong id = get_global_id(0);
        ///
        ///#define Access(memory) memory[id]
        ///	bool value = {expression};
        ///#undef Access
        ///#define Access(memory) memory[0]
        ///	if (value)
        ///		{target} = value;
        ///#undef Access
        ///}.
        /// </summary>
        internal static string any {
            get {
                return ResourceManager.GetString("any", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to /* apply {operation}
        /// * apply operation to all elements
        /// */
        ///kernel void Kernel(
        ///		const ulong length{arguments}
        ///	)
        ///{
        ///	ulong id = get_global_id(0);
        ///
        ///#define Access(memory) memory[id]
        ///	{type} value = {expression};
        ///#undef Access
        ///	value = {operation};
        ///#define Access(memory) memory[id]
        ///	{target} = {resultExpression};
        ///#undef Access
        ///}.
        /// </summary>
        internal static string apply {
            get {
                return ResourceManager.GetString("apply", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to /* apply {operation}
        /// * apply operation to all elements
        /// */
        ///kernel void Kernel(
        ///		const ulong length{arguments}
        ///	)
        ///{
        ///	ulong row = get_global_id(1);
        ///	ulong col = get_global_id(0);
        ///
        ///#define Access(mem,n,f0,b0,f1,b1) (mem)[((b0)*row+(f0))*(n)+((b1)*(col)+(f1))]
        ///	{type} value = {expression};
        ///#undef Access
        ///	value = {operation};
        ///#define Access(mem,n,f0,b0,f1,b1) (mem)[((b0)*row+(f0))*(n)+((b1)*(col)+(f1))]
        ///	{target} = {resultExpression};
        ///#undef Access
        ///}.
        /// </summary>
        internal static string apply_indexer {
            get {
                return ResourceManager.GetString("apply_indexer", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to /* element wise copy
        /// * {target} = {resultExpression}
        /// */
        ///kernel void Kernel(
        ///		ulong count{arguments}
        ///	)
        ///{
        ///	ulong index = get_local_id(0);
        ///
        ///#define Access(arr) arr[index] 
        ///	{target} = {resultExpression};
        ///#undef Access
        ///}
        ///.
        /// </summary>
        internal static string ElementWiseCopy {
            get {
                return ResourceManager.GetString("ElementWiseCopy", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to /* indexed element wise copy
        /// * {target} = {resultExpression}
        /// */
        ///kernel void Kernel(
        ///		ulong count{arguments}
        ///	)
        ///{
        ///	ulong row = get_global_id(1);
        ///	ulong col = get_global_id(0);
        ///
        ///#define Access(mem,n,f0,b0,f1,b1) (mem)[((b0)*row+(f0))*(n)+((b1)*(col)+(f1))]
        ///	{target} = {resultExpression};
        ///#undef Access
        ///}
        ///.
        /// </summary>
        internal static string ElementWiseCopy_indexer {
            get {
                return ResourceManager.GetString("ElementWiseCopy_indexer", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to /* Left Division
        /// */
        ///kernel void Kernel(
        ///		const ulong length,
        ///		global {type} * L,
        ///		global {type} * U,
        ///		global {type} * z{arguments}
        ///	)
        ///{
        ///	for (ulong k = 1; k &lt;= length; k++) {
        ///		U[k*length+k] = 1;
        ///
        ///		for (ulong i = k; i &lt;= length; i++) {
        ///			{type} sum = 0;
        ///			for (ulong p = 1; p &lt;= k-1; p++) {
        ///				sum += L[i*length+p] * U[p*length+k];
        ///			}
        ///#define Access(memory) memory[i*length+k]
        ///			L[i*length+k] = {leftExpression} - sum;
        ///#undef Access
        ///		}
        ///
        ///		for (ulong j = k+1; j &lt;= length; j++)  [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string LeftDivision {
            get {
                return ResourceManager.GetString("LeftDivision", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to /* Left LU Division
        /// */
        ///kernel void Kernel(
        ///		const ulong length,
        ///		global {type} * z,
        ///		global {type} * L/* not a mistake! */
        ///		/* first arg is U */{arguments}
        ///	)
        ///{
        ///	for (ulong i = 1; i &lt;= length; i++) {
        ///		{type} sum = 0;
        ///		for (ulong p = 1; p &lt; 1; p++) {
        ///			sum += L[i*length+p] * z[p];
        ///		}
        ///#define Access(memory) memory[i]
        ///		z[i] = ({rightExpression} - sum) / L[i*length+i];
        ///#undef Access
        ///	}
        ///
        ///	for (ulong i = length; i != 0; i--) {
        ///		{type} sum = 0;
        ///		for (ulong p = length; p &gt; i; p--) { [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string LeftLUDivision {
            get {
                return ResourceManager.GetString("LeftLUDivision", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to /* LU Decomposition
        /// */
        ///kernel void Kernel(
        ///		const ulong length,
        ///		global {type} * L{arguments}
        ///		/* last arg is U */
        ///	)
        ///{
        ///	for (ulong k = 1; k &lt;= length; k++) {
        ///#define Access(memory) memory[k*length+k]
        ///		{target} = 1;
        ///#undef Access
        ///
        ///		for (ulong i = k; i &lt;= length; i++) {
        ///			{type} sum = 0;
        ///			for (ulong p = 1; p &lt;= k-1; p++) {
        ///#define Access(memory) memory[p*length+k]
        ///				sum += L[i*length+p] * {target};
        ///#undef Access
        ///			}
        ///#define Access(memory) memory[i*length+k]
        ///			L[i*length+k] = [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string LU {
            get {
                return ResourceManager.GetString("LU", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to /* Matrix Exponent
        /// * global range &apos;smallest a where a=16*k &gt; n&apos; x &apos;smallest b where b=16*l &gt; n&apos;
        /// * local range 16 x 16
        /// * local memory 16*16*float
        /// */
        ///kernel void Kernel(
        ///		ulong n,
        ///		local {type} * A,
        ///		local {type} * B{arguments}
        ///	)
        ///{
        ///	ulong m = n;
        ///	ulong p = n;
        ///	ulong4 pos = (ulong4)(get_global_id(0), get_global_id(1), get_local_id(0), get_local_id(1));
        ///	for (ulong pow = 1; pow &lt; {power}; pow++) {
        ///		{type} value = 0.0f;
        ///
        ///		for (ulong i = 0; i &lt; m; i += 16) {
        ///#define Access(matrix) (mat [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string MatrixExponent {
            get {
                return ResourceManager.GetString("MatrixExponent", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to /* Matrix Matrix Multiplication
        /// * global range &apos;smallest a where a=16*k &gt; n&apos; x &apos;smallest b where b=16*l &gt; p&apos;
        /// * local range 16 x 16
        /// * local memory 16*16*float
        /// */
        ///kernel void Kernel(
        ///		ulong n,
        ///		ulong m,
        ///		ulong p,
        ///		local {type} * A,
        ///		local {type} * B{arguments}
        ///	)
        ///{
        ///	ulong4 pos = (ulong4)(get_global_id(0), get_global_id(1), get_local_id(0), get_local_id(1));
        ///	{type} value = 0.0f;
        ///
        ///	for (ulong i = 0; i &lt; m; i += 16) {
        ///#define Access(matrix) (matrix)[pos.y*m + pos.z + i]
        ///		A[(pos.w&lt;&lt;4) [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string MatrixMatrixMultiplication {
            get {
                return ResourceManager.GetString("MatrixMatrixMultiplication", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to /* Matrix Transpose
        /// * global range n x m
        /// * local range null
        /// * no local memory */
        ///kernel void Kernel(
        ///		ulong n, 
        ///		ulong m{arguments}
        ///	)
        ///{
        ///#define Access(matrix) matrix[get_global_id(0)*n+get_global_id(1)]
        ///	{type} value = {leftExpression};
        ///#undef Access
        ///#define Access(matrix) matrix[get_global_id(1)*m+get_global_id(0)]
        ///	{target} = {resultExpression};
        ///#undef Access
        ///}
        ///.
        /// </summary>
        internal static string MatrixTranspose {
            get {
                return ResourceManager.GetString("MatrixTranspose", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to /* Matrix Vector Multiplication
        /// * global range 32 x N
        /// * local range 32 x 1
        /// * local memory 32*float
        /// */
        ///kernel void Kernel(
        ///		ulong n,
        ///		ulong m,
        ///		local {type} * work{arguments}
        ///	)
        ///{
        ///	{type}16 s = ({type}16)(0);
        ///	ulong mmax = m&gt;&gt;4;
        ///	ulong mrest = m&amp;0xf;
        ///	for (ulong i = get_global_id(0); i &lt; mmax; i += get_global_size(0)) {
        ///#define Access(argument) vload16(i, argument + get_global_id(1) * m)
        ///		{type}16 left = {leftExpression};
        ///#undef Access
        ///#define Access(argument) vload16(i, argument)
        /// [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string MatrixVectorMultiplication {
            get {
                return ResourceManager.GetString("MatrixVectorMultiplication", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to /* pps {operation}
        /// * 1st stage
        /// * taken from http://developer.amd.com
        /// */
        ///kernel void Kernel(
        ///		const ulong length,
        ///		local {type} * scratch{arguments}
        ///	)
        ///{
        ///	ulong global_index = get_global_id(0);
        ///	{type} acc = {identity};
        ///	while (global_index &lt; length) {
        ///#define Access(memory) memory[global_index]
        ///		{type} element = {expression};
        ///#undef Access
        ///#define mine acc
        ///#define other element
        ///		acc = {operation};
        ///#undef other
        ///#undef mine
        ///		global_index += get_global_size(0);
        ///	}
        ///
        ///	ulong local_i [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string pps1 {
            get {
                return ResourceManager.GetString("pps1", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to /* pps {operation}
        /// * 2st stage
        /// */
        ///kernel void Kernel(
        ///		const ulong length{arguments}
        ///	)
        ///{
        ///	{type} value = {identity};
        ///	for (ulong i = 0; i &lt; length; i++) {
        ///#define Access(memory) memory[i]
        ///		{type} other = {expression};
        ///#undef Access
        ///#define mine value
        ///		value = {operation};
        ///#undef mine
        ///	}
        ///#define Access(memory) memory[0]
        ///	{target} = {resultExpression};
        ///#undef Access
        ///}.
        /// </summary>
        internal static string pps2 {
            get {
                return ResourceManager.GetString("pps2", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to // NOTE: not used at the time
        ///
        ///#pragma OPENCL EXTENSION cl_khr_fp64 : enable
        ///
        ///#define Reduction(a, b) {reduction}
        ///
        ///kernel void Kernel(
        ///		ulong n,
        ///		local {type} * communication{arguments}
        ///) {
        ///	int globalIndex = get_global_id(0);
        ///	int localIndex = get_local_id(0);
        ///	int globalSize = get_global_size(0);
        ///	int groupSize = get_local_size(0);
        ///	int groupIndex = get_group_id(0);
        ///	int index = globalIndex;
        ///	{type} value = {identity};
        ///	while (index &lt; n) {
        ///		#define Access(argument) argument[index]
        ///		 [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string Reduction {
            get {
                return ResourceManager.GetString("Reduction", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to /* Vector Matrix Multiplication
        /// * global range p
        /// * local range null
        /// * no local memory
        /// */
        ///kernel void Kernel(
        ///		ulong m,
        ///		ulong p{arguments}
        ///	)
        ///{
        ///	{type} value = 0;
        ///	for(ulong row = 0; row &lt; m; row += 1) {
        ///		#define Access(argument) argument[row]
        ///		{type} left = {leftExpression};
        ///		#undef Access
        ///		#define Access(argument) argument[row * p + get_local_id(0)]
        ///		{type} right = {rightExpression};
        ///		#undef Access
        ///		value += left * right;
        ///	}
        ///	#define Access(argument) argument[get_local_id( [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string VectorMatrixMultiplication {
            get {
                return ResourceManager.GetString("VectorMatrixMultiplication", resourceCulture);
            }
        }
    }
}