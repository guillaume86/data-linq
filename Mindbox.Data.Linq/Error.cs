using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data.Linq.Mapping;
using System.Data.Linq.SqlClient;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Xml;

namespace System.Data.Linq
{
    /// <summary>
    /// DLinq-providerbase-specific custom exception factory.
    /// </summary>
    internal class Error
    {
        /// <summary>
        /// Exception thrown when a query cannot execute against a particular SQL server version.
        /// </summary>
        static internal Exception ExpressionNotSupportedForSqlServerVersion(Collection<string> reasons)
        {
            StringBuilder exceptionMessage = new StringBuilder("CannotTranslateExpressionToSql: ");
            foreach (string reason in reasons)
            {
                exceptionMessage.AppendLine(reason);
            }
            return new NotSupportedException(exceptionMessage.ToString());
        }

        public static Exception ArgumentNull(string sequence)
        {
            return new ArgumentNullException(sequence);
        }

        public static Exception EntitySetDataBindingWithAbstractBaseClass(string name)
        {
            return new InvalidOperationException(String.Format(Strings.EntitySetDataBindingWithAbstractBaseClass, name));
        }

        public static Exception EntitySetDataBindingWithNonPublicDefaultConstructor(string name)
        {
            return new InvalidOperationException(String.Format(Strings.EntitySetDataBindingWithNonPublicDefaultConstructor, name));
        }

        public static Exception InvalidFieldInfo(Type objectType, Type fieldType, FieldInfo fi)
        {
            return new InvalidOperationException(Strings.DefaultErrorMessage(new object[] { objectType, fieldType, fi }));
        }

        public static Exception ArgumentWrongValue(string rowtype)
        {
            return new ArgumentException(Strings.DefaultErrorMessage(new object[] { rowtype }));
        }

        public static Exception UnexpectedNode(SqlNodeType nodeType)
        {
            return new InvalidOperationException(Strings.DefaultErrorMessage(new object[] { nodeType }));
        }

        public static Exception UnexpectedNode(SqlNode node)
        {
            return new InvalidOperationException(Strings.DefaultErrorMessage(new object[] { node }));
        }

        public static Exception ColumnReferencedIsNotInScope(string getColumnName)
        {
            return new InvalidOperationException(Strings.DefaultErrorMessage(new object[] { getColumnName }));
        }

        public static Exception CannotAddChangeConflicts()
        {
            return new InvalidOperationException(Strings.CannotAddChangeConflicts);
        }

        public static Exception ExpectedQueryableArgument(string expression, Type qType)
        {
            return new InvalidOperationException(String.Format(Strings.ExpectedQueryableArgument, expression, qType));
        }

        public static Exception ColumnClrTypeDoesNotAgreeWithExpressionsClrType()
        {
            return new InvalidOperationException(Strings.DefaultErrorMessage());
        }

        public static Exception ProviderTypeNotFound(string provider)
        {
            return new InvalidOperationException(Strings.DefaultErrorMessage(new object[] { provider }));
        }

        public static Exception ArgumentOutOfRange(string mi)
        {
            return new ArgumentOutOfRangeException(mi);
        }

        public static Exception ClassLiteralsNotAllowed(Type clrType)
        {
            return new InvalidOperationException(Strings.DefaultErrorMessage(new object[] { clrType }));
        }

        public static Exception CouldNotHandleAliasRef(SqlNodeType nodeType)
        {
            return new InvalidOperationException(Strings.DefaultErrorMessage(new object[] { nodeType }));
        }

        public static Exception EmptyCaseNotSupported()
        {
            return new InvalidOperationException(Strings.DefaultErrorMessage());
        }

        public static Exception ExpectedPredicateFoundBit()
        {
            return new InvalidOperationException(Strings.DefaultErrorMessage());
        }

        public static Exception ExpectedBitFoundPredicate()
        {
            return new InvalidOperationException(Strings.DefaultErrorMessage());
        }

        public static Exception CouldNotFindTypeFromMapping(string name)
        {
            return new InvalidOperationException(Strings.DefaultErrorMessage(new object[] { name }));
        }

        public static Exception ConvertToCharFromBoolNotSupported()
        {
            return new InvalidOperationException(Strings.DefaultErrorMessage());
        }

        public static Exception CreateDatabaseFailedBecauseOfClassWithNoMembers(Type type)
        {
            return new InvalidOperationException(Strings.DefaultErrorMessage(new object[] { type }));
        }

        public static Exception MethodHasNoSupportConversionToSql(object x)
        {
            return new InvalidOperationException(Strings.DefaultErrorMessage(new object[] { x }));
        }

        public static Exception CannotAssignNull(Type type)
        {
            return new InvalidOperationException(Strings.DefaultErrorMessage(new object[] { type }));
        }

        public static Exception CannotAssignNull(MemberInfo target)
        {
            return new InvalidOperationException(
                    string.Format("CannotAssignNull: {0}.{1}.", target.DeclaringType.Name, target.Name));
        }

        public static Exception UnsafeStringConversion(string toQueryString, string p1)
        {
            return new InvalidOperationException(Strings.DefaultErrorMessage(new object[] { toQueryString, p1 }));
        }

        public static Exception InsertAutoSyncFailure()
        {
            return new InvalidOperationException(Strings.InsertAutoSyncFailure);
        }

        public static Exception CouldNotCreateAccessorToProperty(Type objectType, Type propertyType, PropertyInfo pi)
        {
            return new InvalidOperationException(
                Strings.DefaultErrorMessage(new object[] { objectType, propertyType, pi }));
        }

        public static Exception CannotAttachAddNonNewEntities()
        {
            return new InvalidOperationException(Strings.CannotAttachAddNonNewEntities);
        }

        public static Exception InvalidMethodExecution(string name)
        {
            return new InvalidOperationException(Strings.DefaultErrorMessage(new object[] { name }));
        }

        public static Exception MappedTypeMustHaveDefaultConstructor(Type type)
        {
            return new InvalidOperationException(Strings.DefaultErrorMessage(new object[] { type }));
        }

        public static Exception TransactionDoesNotMatchConnection()
        {
            return new InvalidOperationException(Strings.DefaultErrorMessage());
        }

        public static Exception InvalidFormatNode(object x)
        {
            return new InvalidOperationException(Strings.DefaultErrorMessage(new object[] { x }));
        }

        public static Exception UnexpectedFloatingColumn()
        {
            return new InvalidOperationException(Strings.DefaultErrorMessage());
        }

        public static Exception UnexpectedTypeCode(object x)
        {
            return new InvalidOperationException(Strings.DefaultErrorMessage(new object[] { x }));
        }

        public static Exception UnexpectedSharedExpression()
        {
            return new InvalidOperationException(Strings.DefaultErrorMessage());
        }

        public static Exception UnexpectedSharedExpressionReference()
        {
            return new InvalidOperationException(Strings.DefaultErrorMessage());
        }

        public static Exception MethodCannotBeFound(string methodName)
        {
            return new InvalidOperationException(Strings.DefaultErrorMessage(new object[] { methodName }));
        }

        public static Exception IncludeNotAllowedAfterFreeze()
        {
            return new InvalidOperationException(Strings.IncludeNotAllowedAfterFreeze);
        }

        public static Exception NoMethodInTypeMatchingArguments(Type type)
        {
            return new InvalidOperationException(Strings.DefaultErrorMessage(new object[] { type }));
        }

        public static Exception SubqueryNotAllowedAfterFreeze()
        {
            return new InvalidOperationException(Strings.SubqueryNotAllowedAfterFreeze);
        }

        public static Exception UnhandledStringTypeComparison()
        {
            return new InvalidOperationException(Strings.DefaultErrorMessage());
        }

        public static Exception DataContextCannotBeUsedAfterDispose()
        {
            return new InvalidOperationException(Strings.DataContextCannotBeUsedAfterDispose);
        }

        public static Exception UnableToAssignValueToReadonlyProperty(PropertyInfo pi)
        {
            return new InvalidOperationException(Strings.DefaultErrorMessage(new object[] { pi }));
        }

        public static Exception DatabaseNodeNotFound(string httpSchemasMicrosoftComLinqtosqlMapping)
        {
            return new InvalidOperationException(Strings.DefaultErrorMessage(new object[] { httpSchemasMicrosoftComLinqtosqlMapping }));
        }

        public static Exception UnrecognizedExpressionNode(object x)
        {
            return new InvalidOperationException(Strings.DefaultErrorMessage(new object[] { x }));
        }

        public static Exception InvalidUseOfGenericMethodAsMappedFunction(string name)
        {
            return new InvalidOperationException(Strings.DefaultErrorMessage(new object[] { name }));
        }

        public static Exception InvalidGroupByExpressionType(string name)
        {
            return new InvalidOperationException(Strings.DefaultErrorMessage(new object[] { name }));
        }

        public static Exception InvalidLoadOptionsLoadMemberSpecification()
        {
            return new InvalidOperationException(Strings.InvalidLoadOptionsLoadMemberSpecification);
        }

        public static Exception ProviderTypeNull()
        {
            return new InvalidOperationException(Strings.ProviderTypeNull);
        }

        public static Exception ProviderDoesNotImplementRequiredInterface(Type providerType, Type type)
        {
            return new InvalidOperationException(
                String.Format(Strings.ProviderDoesNotImplementRequiredInterface, providerType, type));
        }

        public static Exception CouldNotConvert(Type fromType, Type toType)
        {
            return new InvalidOperationException(String.Format(Strings.CouldNotConvert, fromType, toType));
        }

        public static Exception ColumnIsDefinedInMultiplePlaces(string getColumnName)
        {
            return new InvalidOperationException(Strings.DefaultErrorMessage(new object[] { getColumnName }));
        }

        public static Exception UnionIncompatibleConstruction()
        {
            return new InvalidOperationException(Strings.DefaultErrorMessage());
        }

        public static Exception UnionDifferentMembers()
        {
            return new InvalidOperationException(Strings.DefaultErrorMessage());
        }

        public static Exception UnionDifferentMemberOrder()
        {
            return new InvalidOperationException(Strings.DefaultErrorMessage());
        }

        public static Exception UnhandledExpressionType(object x)
        {
            return new InvalidOperationException(String.Format(Strings.UnhandledExpressionType, x));
        }

        public static Exception CouldNotFindRequiredAttribute(string attribute, string readOuterXml)
        {
            return new InvalidOperationException(Strings.DefaultErrorMessage(new object[] { attribute, readOuterXml }));
        }

        public static Exception LinkAlreadyLoaded()
        {
            return new InvalidOperationException(Strings.DefaultErrorMessage());
        }

        public static Exception UnsupportedNodeType(ExpressionType nodeType)
        {
            return new InvalidOperationException(Strings.DefaultErrorMessage(new object[] { nodeType }));
        }

        public static Exception UnhandledBindingType(MemberBindingType bindingType)
        {
            return new InvalidOperationException(String.Format(Strings.UnhandledBindingType, bindingType));
        }

        public static Exception UnableToResolveRootForType(Type type)
        {
            return new InvalidOperationException(Strings.DefaultErrorMessage(new object[] { type }));
        }

        public static Exception CouldNotDetermineDbGeneratedSqlType(Type type)
        {
            return new InvalidOperationException(Strings.DefaultErrorMessage(new object[] { type }));
        }

        public static Exception IncludeCycleNotAllowed()
        {
            return new InvalidOperationException(Strings.IncludeCycleNotAllowed);
        }

        public static Exception InvalidGroupByExpression()
        {
            return new InvalidOperationException(Strings.DefaultErrorMessage());
        }

        public static Exception ExpectedEmptyElement(string nodeName, XmlNodeType nodeType, string name)
        {
            return new InvalidOperationException(Strings.DefaultErrorMessage(new object[] { nodeName, nodeType, name }));
        }

        public static Exception InvalidOrderByExpression(string toQueryString)
        {
            return new InvalidOperationException(Strings.DefaultErrorMessage(new object[] { toQueryString }));
        }

        public static Exception SubqueryNotSupportedOn(MemberInfo mi)
        {
            return new InvalidOperationException(String.Format(Strings.SubqueryNotSupportedOn, mi));
        }

        public static Exception SubqueryNotSupportedOnType(string name, Type declaringType)
        {
            return new InvalidOperationException(String.Format(Strings.SubqueryNotSupportedOnType, name, declaringType));
        }

        public static Exception SubqueryMustBeSequence()
        {
            return new InvalidOperationException(Strings.SubqueryMustBeSequence);
        }

        public static Exception RefreshOfDeletedObject()
        {
            return new InvalidOperationException(Strings.RefreshOfDeletedObject);
        }

        public static Exception OptionsCannotBeModifiedAfterQuery()
        {
            return new InvalidOperationException(Strings.OptionsCannotBeModifiedAfterQuery);
        }

        public static Exception SubqueryDoesNotSupportOperator(string name)
        {
            return new InvalidOperationException(String.Format(Strings.SubqueryDoesNotSupportOperator, name));
        }

        public static Exception EntityRefAlreadyLoaded()
        {
            return new InvalidOperationException(Strings.DefaultErrorMessage());
        }

        public static Exception InvalidReferenceToRemovedAliasDuringDeflation()
        {
            return new InvalidOperationException(Strings.DefaultErrorMessage());
        }

        public static Exception ColumnIsNotAccessibleThroughDistinct(string getColumnName)
        {
            return new InvalidOperationException(Strings.DefaultErrorMessage(new object[] { getColumnName }));
        }

        public static Exception UnrecognizedElement(string format)
        {
            return new InvalidOperationException(Strings.DefaultErrorMessage(new object[] { format }));
        }

        public static Exception UnexpectedElement(string database, string format)
        {
            return new InvalidOperationException(Strings.DefaultErrorMessage(new object[] { database, format }));
        }

        public static Exception ColumnIsNotAccessibleThroughGroupBy(string getColumnName)
        {
            return new InvalidOperationException(Strings.DefaultErrorMessage(new object[] { getColumnName }));
        }

        public static Exception CouldNotDetermineSqlType(Type type)
        {
            return new InvalidOperationException(Strings.DefaultErrorMessage(new object[] { type }));
        }

        public static Exception DeferredLoadingRequiresObjectTracking()
        {
            return new InvalidOperationException(Strings.DeferredLoadingRequiresObjectTracking);
        }

        public static Exception IQueryableCannotReturnSelfReferencingConstantExpression()
        {
            return new InvalidOperationException(Strings.DefaultErrorMessage());
        }

        public static Exception CapturedValuesCannotBeSequences()
        {
            return new InvalidOperationException(Strings.DefaultErrorMessage());
        }

        public static Exception ConstructedArraysNotSupported()
        {
            return new InvalidOperationException(Strings.DefaultErrorMessage());
        }

        public static Exception ParametersCannotBeSequences()
        {
            return new InvalidOperationException(Strings.DefaultErrorMessage());
        }

        public static Exception UnrecognizedAttribute(string format)
        {
            return new InvalidOperationException(Strings.DefaultErrorMessage(new object[] { format }));
        }

        public static Exception CannotCompareItemsAssociatedWithDifferentTable()
        {
            return new InvalidOperationException(Strings.DefaultErrorMessage());
        }

        public static Exception ObjectTrackingRequired()
        {
            return new InvalidOperationException(Strings.ObjectTrackingRequired);
        }

        public static Exception QueryWasCompiledForDifferentMappingSource()
        {
            return new InvalidOperationException(Strings.QueryWasCompiledForDifferentMappingSource);
        }

        public static Exception ContextNotInitialized()
        {
            return new InvalidOperationException(Strings.DefaultErrorMessage());
        }

        public static Exception IifReturnTypesMustBeEqual(string name, string s)
        {
            return new InvalidOperationException(Strings.DefaultErrorMessage(new object[] { name, s }));
        }

        public static Exception UnionWithHierarchy()
        {
            return new InvalidOperationException(Strings.DefaultErrorMessage());
        }

        public static Exception DatabaseDeleteThroughContext()
        {
            return new InvalidOperationException(Strings.DefaultErrorMessage());
        }

        public static Exception CannotPerformOperationDuringSubmitChanges()
        {
            return new InvalidOperationException(Strings.CannotPerformOperationDuringSubmitChanges);
        }

        public static Exception ArgumentWrongType(object x, object y, object z)
        {
            return new InvalidOperationException(Strings.DefaultErrorMessage(new object[] { x, y, z }));
        }

        public static Exception IdentityChangeNotAllowed(string name, string s)
        {
            return new InvalidOperationException(String.Format(Strings.IdentityChangeNotAllowed, name, s));
        }

        public static Exception CannotPerformOperationOutsideSubmitChanges()
        {
            return new InvalidOperationException(Strings.CannotPerformOperationOutsideSubmitChanges);
        }

        public static Exception DbGeneratedChangeNotAllowed(string name, string s)
        {
            return new InvalidOperationException(String.Format(Strings.DbGeneratedChangeNotAllowed, name, s));
        }

        public static Exception ProviderNotSupported(string dbName, string sqlProviderInvariantName)
        {
            return new InvalidOperationException(Strings.DefaultErrorMessage(new object[] { dbName, sqlProviderInvariantName }));
        }

        public static Exception ComparisonNotSupportedForType(Type clrType)
        {
            return new InvalidOperationException(Strings.DefaultErrorMessage(new object[] { clrType }));
        }

        public static Exception TypeIsNotMarkedAsTable(Type type)
        {
            return new InvalidOperationException(String.Format(Strings.TypeIsNotMarkedAsTable, type));
        }

        public static Exception CouldNotGetTableForSubtype(Type type, Type type1)
        {
            return new InvalidOperationException(String.Format(Strings.CouldNotGetTableForSubtype, type, type1));
        }

        public static Exception BadParameterType(Type type)
        {
            return new InvalidOperationException(Strings.DefaultErrorMessage(new object[] { type }));
        }

        public static Exception InvalidConnectionArgument(string connection)
        {
            return new InvalidOperationException(Strings.DefaultErrorMessage(new object[] { connection }));
        }

        public static Exception NoDiscriminatorFound(object x)
        {
            return new InvalidOperationException(Strings.DefaultErrorMessage(new object[] { x }));
        }

        public static Exception DiscriminatorClrTypeNotSupported(string name, string s, Type type)
        {
            return new InvalidOperationException(Strings.DefaultErrorMessage(new object[] { name, s, type }));
        }

        public static Exception NonEntityAssociationMapping(Type type, string name, Type p2)
        {
            return new InvalidOperationException(String.Format(Strings.NonEntityAssociationMapping, type, name, p2));
        }

        public static Exception InheritanceTypeDoesNotDeriveFromRoot(Type type, Type type1)
        {
            return new InvalidOperationException(Strings.DefaultErrorMessage(new object[] { type, type1 }));
        }

        public static Exception AbstractClassAssignInheritanceDiscriminator(Type type)
        {
            return new InvalidOperationException(Strings.DefaultErrorMessage(new object[] { type }));
        }

        public static Exception InheritanceCodeMayNotBeNull()
        {
            return new InvalidOperationException(Strings.DefaultErrorMessage());
        }

        public static Exception InheritanceTypeHasMultipleDiscriminators(object x)
        {
            return new InvalidOperationException(Strings.DefaultErrorMessage(new object[] { x }));
        }

        public static Exception InheritanceTypeNotRegistered(object x)
        {
            return new InvalidOperationException(Strings.DefaultErrorMessage(new object[] { x }));
        }

        public static Exception InheritanceCodeUsedForMultipleTypes(object codeValue)
        {
            return new InvalidOperationException(Strings.DefaultErrorMessage(new object[] { codeValue }));
        }

        public static Exception InheritanceTypeHasMultipleDefaults(object x)
        {
            return new InvalidOperationException(Strings.DefaultErrorMessage(new object[] { x }));
        }

        public static Exception InheritanceHierarchyDoesNotDefineDefault(Type type)
        {
            return new InvalidOperationException(Strings.DefaultErrorMessage(new object[] { type }));
        }

        public static Exception BadProjectionInSelect()
        {
            return new InvalidOperationException(Strings.DefaultErrorMessage());
        }

        public static Exception EntitySetAlreadyLoaded()
        {
            return new InvalidOperationException(Strings.EntitySetAlreadyLoaded);
        }

        public static Exception NonInheritanceClassHasDiscriminator(MetaType type)
        {
            return new InvalidOperationException(Strings.DefaultErrorMessage(new object[] { type }));
        }

        public static Exception InheritanceSubTypeIsAlsoRoot(Type type)
        {
            return new InvalidOperationException(Strings.DefaultErrorMessage(new object[] { type }));
        }

        public static Exception ModifyDuringAddOrRemove()
        {
            return new InvalidOperationException(Strings.ModifyDuringAddOrRemove);
        }

        public static Exception MemberMappedMoreThanOnce(string name)
        {
            return new InvalidAsynchronousStateException(Strings.DefaultErrorMessage(new object[] { name }));
        }

        public static Exception ProviderCannotBeUsedAfterDispose()
        {
            return new InvalidOperationException(Strings.DefaultErrorMessage());
        }

        public static Exception CouldNotFindRuntimeTypeForMapping(string name)
        {
            return new InvalidOperationException(Strings.DefaultErrorMessage(new object[] { name }));
        }

        public static Exception EntitySetModifiedDuringEnumeration()
        {
            return new InvalidOperationException(Strings.EntitySetModifiedDuringEnumeration);
        }

        public static Exception PrimaryKeyInSubTypeNotSupported(string name, string s)
        {
            return new InvalidOperationException(Strings.DefaultErrorMessage(new object[] { name, s }));
        }

        public static Exception SqlMethodOnlyForSql(MethodBase getCurrentMethod)
        {
            return new InvalidOperationException(Strings.DefaultErrorMessage(new object[] { getCurrentMethod }));
        }

        public static Exception InconsistentAssociationAndKeyChange(string name, string s)
        {
            return new InvalidOperationException(String.Format(Strings.InconsistentAssociationAndKeyChange, name, s));
        }

        public static Exception CouldNotDetermineCatalogName()
        {
            return new InvalidOperationException(Strings.DefaultErrorMessage());
        }

        public static Exception UnrecognizedRefreshObject()
        {
            return new InvalidAsynchronousStateException(Strings.UnrecognizedRefreshObject);
        }

        public static Exception CouldNotRemoveRelationshipBecauseOneSideCannotBeNull(string name, string s, StringBuilder keys)
        {
            return new InvalidOperationException(
                Strings.DefaultErrorMessage(new object[] { name, s, keys }));
        }

        public static Exception CreateDatabaseFailedBecauseOfContextWithNoTables(string databaseName)
        {
            return new InvalidOperationException(Strings.DefaultErrorMessage(new object[] { databaseName }));
        }

        public static Exception RefreshOfNewObject()
        {
            return new InvalidOperationException(Strings.RefreshOfNewObject);
        }

        public static Exception TypeBinaryOperatorNotRecognized()
        {
            return new InvalidAsynchronousStateException(Strings.DefaultErrorMessage());
        }

        public static Exception CannotChangeInheritanceType(
            object dbDiscriminator,
            object currentDiscriminator,
            string name,
            MetaType currentTypeFromDiscriminator)
        {
            return new InvalidOperationException(String.Format(Strings.CannotChangeInheritanceType, dbDiscriminator + ", " +
                currentDiscriminator, name, currentTypeFromDiscriminator));
        }

        public static Exception DidNotExpectTypeBinding()
        {
            return new InvalidOperationException(Strings.DefaultErrorMessage());
        }

        public static Exception DidNotExpectAs(UnaryExpression unaryExpression)
        {
            return new InvalidOperationException(Strings.DefaultErrorMessage(new object[] { unaryExpression }));
        }

        public static Exception CycleDetected()
        {
            return new InvalidOperationException(Strings.CycleDetected);
        }

        public static Exception TwoMembersMarkedAsPrimaryKeyAndDBGenerated(MemberInfo member, MemberInfo memberInfo)
        {
            return new InvalidOperationException(
                Strings.DefaultErrorMessage(new object[] { member, memberInfo }));
        }

        public static Exception IdentityClrTypeNotSupported(MetaType declaringType, string name, Type type)
        {
            return new InvalidOperationException(
                Strings.DefaultErrorMessage(new object[] { declaringType, name, type }));
        }

        public static Exception TwoMembersMarkedAsRowVersion(MemberInfo member, MemberInfo memberInfo)
        {
            return new InvalidAsynchronousStateException(Strings.DefaultErrorMessage(new object[] { member, memberInfo }));
        }

        public static Exception TwoMembersMarkedAsInheritanceDiscriminator(MemberInfo member, MemberInfo memberInfo)
        {
            return new InvalidOperationException(
                Strings.DefaultErrorMessage(new object[] { member, memberInfo }));
        }

        public static Exception MappedMemberHadNoCorrespondingMemberInType(string memberName, string name)
        {
            return new InvalidOperationException(Strings.DefaultErrorMessage(new object[] { memberName, name }));
        }

        public static Exception ExpectedClrTypesToAgree(Type newClrType, Type clrType)
        {
            return new InvalidOperationException(Strings.DefaultErrorMessage(new object[] { newClrType, clrType }));
        }

        public static Exception UnsupportedStringConstructorForm()
        {
            return new InvalidOperationException(Strings.DefaultErrorMessage());
        }

        public static Exception CouldNotGetClrType()
        {
            return new InvalidOperationException(Strings.DefaultErrorMessage());
        }

        public static Exception CouldNotGetSqlType()
        {
            return new InvalidOperationException(Strings.DefaultErrorMessage());
        }

        public static Exception VbLikeDoesNotSupportMultipleCharacterRanges()
        {
            return new InvalidOperationException(Strings.DefaultErrorMessage());
        }

        public static Exception CouldNotTranslateExpressionForReading(Expression sourceExpression)
        {
            return new InvalidOperationException(Strings.DefaultErrorMessage(new object[] { sourceExpression }));
        }

        public static Exception UnsupportedDateTimeConstructorForm()
        {
            return new InvalidOperationException(Strings.DefaultErrorMessage());
        }

        public static Exception WrongDataContext()
        {
            return new InvalidOperationException(Strings.DefaultErrorMessage());
        }

        public static Exception CannotGetInheritanceDefaultFromNonInheritanceClass()
        {
            return new InvalidOperationException(Strings.DefaultErrorMessage());
        }

        public static Exception MappingOfInterfacesMemberIsNotSupported(string name, string s)
        {
            return new InvalidOperationException(Strings.DefaultErrorMessage(new object[] { name, s }));
        }

        public static Exception UnmappedClassMember(string name, string s)
        {
            return new InvalidOperationException(Strings.DefaultErrorMessage(new object[] { name, s }));
        }

        public static Exception CannotMaterializeEntityType(Type type)
        {
            return new InvalidOperationException(Strings.DefaultErrorMessage(new object[] { type }));
        }

        public static Exception CannotPerformOperationForUntrackedObject()
        {
            return new InvalidOperationException(Strings.CannotPerformOperationForUntrackedObject);
        }

        public static Exception VbLikeUnclosedBracket()
        {
            return new InvalidOperationException(Strings.DefaultErrorMessage());
        }

        public static Exception UnsupportedDateTimeOffsetConstructorForm()
        {
            return new InvalidOperationException(Strings.DefaultErrorMessage());
        }

        public static Exception MemberNotPartOfProjection(Type declaringType, string name)
        {
            return new InvalidOperationException(Strings.DefaultErrorMessage(new object[] { declaringType, name }));
        }

        public static Exception CannotMaterializeList(Type clrType)
        {
            return new InvalidOperationException(Strings.DefaultErrorMessage(new object[] { clrType }));
        }

        public static Exception InvalidProviderType(string typeName)
        {
            return new InvalidOperationException(Strings.DefaultErrorMessage(new object[] { typeName }));
        }

        public static Exception NoResultTypesDeclaredForFunction(string name)
        {
            return new InvalidOperationException(Strings.DefaultErrorMessage(new object[] { name }));
        }

        public static Exception TooManyResultTypesDeclaredForFunction(string name)
        {
            return new InvalidOperationException(Strings.DefaultErrorMessage(new object[] { name }));
        }

        public static Exception UnsupportedTimeSpanConstructorForm()
        {
            return new InvalidOperationException(Strings.DefaultErrorMessage());
        }

        public static Exception CouldNotConvertToPropertyOrField(MemberInfo mi)
        {
            return new InvalidOperationException(Strings.DefaultErrorMessage(new object[] { mi }));
        }

        public static Exception LoadOptionsChangeNotAllowedAfterQuery()
        {
            return new InvalidOperationException(Strings.LoadOptionsChangeNotAllowedAfterQuery);
        }

        public static Exception ToStringOnlySupportedForPrimitiveTypes()
        {
            return new InvalidOperationException(Strings.DefaultErrorMessage());
        }

        public static Exception BadStorageProperty(string storageMemberName, Type declaringType, string name)
        {
            return new InvalidOperationException(
                Strings.DefaultErrorMessage(new object[] { storageMemberName, declaringType, name }));
        }

        public static Exception IncorrectAutoSyncSpecification(string name)
        {
            return new InvalidOperationException(Strings.DefaultErrorMessage(new object[] { name }));
        }

        public static Exception MethodFormHasNoSupportConversionToSql(string name, MethodInfo method)
        {
            return new InvalidOperationException(Strings.DefaultErrorMessage(new object[] { name, method }));
        }

        public static Exception UnmappedDataMember(MemberInfo mi, Type declaringType, MetaType type)
        {
            return new InvalidOperationException(Strings.DefaultErrorMessage(new object[] { mi, declaringType, type }));
        }

        public static Exception DeferredMemberWrongType()
        {
            return new InvalidOperationException(Strings.DefaultErrorMessage());
        }

        public static Exception SkipNotSupportedForSequenceTypes()
        {
            return new InvalidOperationException(Strings.DefaultErrorMessage());
        }

        public static Exception CannotAssignToMember(string name)
        {
            return new InvalidOperationException(Strings.DefaultErrorMessage(new object[] { name }));
        }

        public static Exception SkipRequiresSingleTableQueryWithPKs()
        {
            return new InvalidOperationException(Strings.DefaultErrorMessage());
        }

        public static Exception ParameterNotInScope(string name)
        {
            return new InvalidOperationException(Strings.DefaultErrorMessage(new object[] { name }));
        }

        public static Exception SprocsCannotBeComposed()
        {
            return new InvalidOperationException(Strings.DefaultErrorMessage());
        }

        public static Exception InvalidReturnFromSproc(Type returnType)
        {
            return new InvalidOperationException(Strings.DefaultErrorMessage(new object[] { returnType }));
        }

        public static Exception UnhandledDeferredStorageType(Type type)
        {
            return new InvalidOperationException(Strings.DefaultErrorMessage(new object[] { type }));
        }

        public static Exception TypeCouldNotBeAdded(Type type)
        {
            return new InvalidOperationException(String.Format(Strings.TypeCouldNotBeAdded, type));
        }

        public static Exception ConvertToDateTimeOnlyForDateTimeOrString()
        {
            return new InvalidOperationException(Strings.DefaultErrorMessage());
        }

        public static Exception MismatchedThisKeyOtherKey(string name, string s)
        {
            return new InvalidOperationException(Strings.DefaultErrorMessage(new object[] { name, s }));
        }

        public static Exception CantAddAlreadyExistingItem()
        {
            return new InvalidOperationException(Strings.CantAddAlreadyExistingItem);
        }

        public static Exception DidNotExpectTypeChange(Type clrType, Type type)
        {
            return new InvalidAsynchronousStateException(Strings.DefaultErrorMessage(new object[] { clrType, type }));
        }

        public static Exception EntityIsTheWrongType()
        {
            return new InvalidOperationException(Strings.EntityIsTheWrongType);
        }

        public static Exception UnexpectedNull(string metadatamember)
        {
            return new InvalidOperationException(Strings.DefaultErrorMessage(new object[] { metadatamember }));
        }

        public static Exception InvalidDeleteOnNullSpecification(object x)
        {
            return new InvalidOperationException(Strings.DefaultErrorMessage(new object[] { x }));
        }

        public static Exception ValueHasNoLiteralInSql(object value)
        {
            return new InvalidAsynchronousStateException(Strings.DefaultErrorMessage(new object[] { value }));
        }

        public static Exception CannotRemoveUnattachedEntity()
        {
            return new InvalidAsynchronousStateException(Strings.CannotRemoveUnattachedEntity);
        }

        public static Exception CouldNotFindElementTypeInModel(string name)
        {
            return new InvalidOperationException(Strings.DefaultErrorMessage(new object[] { name }));
        }

        public static Exception BinaryOperatorNotRecognized(ExpressionType nodeType)
        {
            return new InvalidOperationException(Strings.DefaultErrorMessage(new object[] { nodeType }));
        }

        public static Exception IncorrectNumberOfParametersMappedForMethod(string methodName)
        {
            return new InvalidOperationException(Strings.DefaultErrorMessage(new object[] { methodName }));
        }

        public static Exception TypeCouldNotBeTracked(Type type)
        {
            return new InvalidOperationException(String.Format(Strings.TypeCouldNotBeTracked, type));
        }

        public static Exception ExpressionNotDeferredQuerySource()
        {
            return new InvalidOperationException(Strings.DefaultErrorMessage());
        }

        public static Exception CannotAttachAsModifiedWithoutOriginalState()
        {
            return new InvalidOperationException(Strings.CannotAttachAsModifiedWithoutOriginalState);
        }

        public static Exception IntersectNotSupportedForHierarchicalTypes()
        {
            return new InvalidOperationException(Strings.DefaultErrorMessage());
        }

        public static Exception CannotAttachAlreadyExistingEntity()
        {
            return new InvalidOperationException(Strings.CannotAttachAlreadyExistingEntity);
        }

        public static Exception ExceptNotSupportedForHierarchicalTypes()
        {
            return new InvalidOperationException(Strings.DefaultErrorMessage());
        }

        public static Exception SequenceOperatorsNotSupportedForType(Type clrType)
        {
            return new InvalidOperationException(Strings.DefaultErrorMessage(new object[] { clrType }));
        }

        public static Exception MemberAccessIllegal(MemberInfo member, Type reflectedType, Type clrType)
        {
            return new InvalidOperationException(Strings.DefaultErrorMessage(new object[] { member, reflectedType, clrType }));
        }

        public static Exception OriginalEntityIsWrongType()
        {
            return new InvalidOperationException(Strings.OriginalEntityIsWrongType);
        }

        public static Exception QueryOnLocalCollectionNotSupported()
        {
            return new InvalidOperationException(Strings.DefaultErrorMessage());
        }

        public static Exception GroupingNotSupportedAsOrderCriterion()
        {
            return new InvalidOperationException(Strings.DefaultErrorMessage());
        }

        public static Exception TypeCannotBeOrdered(Type type)
        {
            return new InvalidOperationException(Strings.DefaultErrorMessage(new object[] { type }));
        }

        public static Exception BadKeyMember(string p0, string keyFields, string name)
        {
            return new InvalidOperationException(Strings.DefaultErrorMessage(new object[] { p0, keyFields, name }));
        }

        public static Exception NonConstantExpressionsNotSupportedFor(string stringContains)
        {
            return new InvalidOperationException(Strings.DefaultErrorMessage(new object[] { stringContains }));
        }

        public static Exception ColumnCannotReferToItself()
        {
            return new InvalidOperationException(Strings.DefaultErrorMessage());
        }

        public static Exception IndexOfWithStringComparisonArgNotSupported()
        {
            return new InvalidOperationException(Strings.DefaultErrorMessage());
        }

        public static Exception CannotPerformCUDOnReadOnlyTable(string toString)
        {
            return new InvalidOperationException(String.Format(Strings.CannotPerformCUDOnReadOnlyTable, toString));
        }

        public static Exception CannotAggregateType(Type type)
        {
            return new InvalidOperationException(Strings.DefaultErrorMessage(new object[] { type }));
        }

        public static Exception CannotConvertToEntityRef(Type actualType)
        {
            return new InvalidOperationException(Strings.DefaultErrorMessage(new object[] { actualType }));
        }

        public static Exception NonCountAggregateFunctionsAreNotValidOnProjections(SqlNodeType aggType)
        {
            return new InvalidOperationException(Strings.DefaultErrorMessage(new object[] { aggType }));
        }

        public static Exception ArgumentTypeMismatch(string provider)
        {
            return new InvalidOperationException(Strings.DefaultErrorMessage(new object[] { provider }));
        }

        public static Exception CompiledQueryAgainstMultipleShapesNotSupported()
        {
            return new InvalidOperationException(Strings.DefaultErrorMessage());
        }

        public static Exception LastIndexOfWithStringComparisonArgNotSupported()
        {
            return new InvalidOperationException(Strings.DefaultErrorMessage());
        }

        public static Exception GeneralCollectionMaterializationNotSupported()
        {
            return new InvalidOperationException(Strings.DefaultErrorMessage());
        }

        public static Exception CannotEnumerateResultsMoreThanOnce()
        {
            return new InvalidOperationException(Strings.DefaultErrorMessage());
        }

        public static Exception MathRoundNotSupported()
        {
            return new InvalidOperationException(Strings.DefaultErrorMessage());
        }

        public static Exception NonConstantExpressionsNotSupportedForRounding()
        {
            return new InvalidOperationException(Strings.DefaultErrorMessage());
        }

        public static Exception QueryOperatorOverloadNotSupported(string name)
        {
            return new InvalidOperationException(Strings.DefaultErrorMessage(new object[] { name }));
        }

        public static Exception QueryOperatorNotSupported(string name)
        {
            return new InvalidOperationException(Strings.DefaultErrorMessage(new object[] { name }));
        }

        public static Exception InvalidSequenceOperatorCall(object x)
        {
            return new InvalidOperationException(Strings.DefaultErrorMessage(new object[] { x }));
        }

        public static Exception MemberCannotBeTranslated(Type declaringType, string name)
        {
            return new InvalidOperationException(Strings.DefaultErrorMessage(new object[] { declaringType, name }));
        }

        public static Exception InsertItemMustBeConstant()
        {
            return new InvalidOperationException(Strings.DefaultErrorMessage());
        }

        public static Exception InvalidDbGeneratedType(string toQueryString)
        {
            return new InvalidOperationException(Strings.DefaultErrorMessage(new object[] { toQueryString }));
        }

        public static Exception UpdateItemMustBeConstant()
        {
            return new InvalidOperationException(Strings.DefaultErrorMessage());
        }

        public static Exception RequiredColumnDoesNotExist(string name)
        {
            return new InvalidOperationException(Strings.DefaultErrorMessage(new object[] { name }));
        }

        public static Exception NotSupported()
        {
            return new NotSupportedException();
        }
    }
}
