/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */

namespace TencentCloud.Lkeap.V20240522
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Lkeap.V20240522.Models;

   public class LkeapClient : AbstractClient{

       private const string endpoint = "lkeap.tencentcloudapi.com";
       private const string version = "2024-05-22";
       private const string sdkVersion = "SDK_NET_3.0.1170";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public LkeapClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public LkeapClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 用于为问答对创建属性标签，以便对内容进行分类和管理。 使用场景：当需要为问答对添加分类标签和属性标记时使用，比如为问答对添加“售后”标签。
        /// </summary>
        /// <param name="req"><see cref="CreateAttributeLabelRequest"/></param>
        /// <returns><see cref="CreateAttributeLabelResponse"/></returns>
        public Task<CreateAttributeLabelResponse> CreateAttributeLabel(CreateAttributeLabelRequest req)
        {
            return InternalRequestAsync<CreateAttributeLabelResponse>(req, "CreateAttributeLabel");
        }

        /// <summary>
        /// 用于为问答对创建属性标签，以便对内容进行分类和管理。 使用场景：当需要为问答对添加分类标签和属性标记时使用，比如为问答对添加“售后”标签。
        /// </summary>
        /// <param name="req"><see cref="CreateAttributeLabelRequest"/></param>
        /// <returns><see cref="CreateAttributeLabelResponse"/></returns>
        public CreateAttributeLabelResponse CreateAttributeLabelSync(CreateAttributeLabelRequest req)
        {
            return InternalRequestAsync<CreateAttributeLabelResponse>(req, "CreateAttributeLabel")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于在系统中创建一个新的知识库。知识库是一个用于存储和管理知识条目的集合，可以包括文档、问答对、属性标签等。创建知识库后，可以向其中添加各种知识条目，以便在后续的知识检索中使用。 使用场景：当需要在系统中建立一个新的知识库以存储和管理特定领域或项目的知识条目时使用。例如，一个用户可能需要创建一个知识库，以存储用户指南、常见问题解答和技术文档。
        /// </summary>
        /// <param name="req"><see cref="CreateKnowledgeBaseRequest"/></param>
        /// <returns><see cref="CreateKnowledgeBaseResponse"/></returns>
        public Task<CreateKnowledgeBaseResponse> CreateKnowledgeBase(CreateKnowledgeBaseRequest req)
        {
            return InternalRequestAsync<CreateKnowledgeBaseResponse>(req, "CreateKnowledgeBase");
        }

        /// <summary>
        /// 用于在系统中创建一个新的知识库。知识库是一个用于存储和管理知识条目的集合，可以包括文档、问答对、属性标签等。创建知识库后，可以向其中添加各种知识条目，以便在后续的知识检索中使用。 使用场景：当需要在系统中建立一个新的知识库以存储和管理特定领域或项目的知识条目时使用。例如，一个用户可能需要创建一个知识库，以存储用户指南、常见问题解答和技术文档。
        /// </summary>
        /// <param name="req"><see cref="CreateKnowledgeBaseRequest"/></param>
        /// <returns><see cref="CreateKnowledgeBaseResponse"/></returns>
        public CreateKnowledgeBaseResponse CreateKnowledgeBaseSync(CreateKnowledgeBaseRequest req)
        {
            return InternalRequestAsync<CreateKnowledgeBaseResponse>(req, "CreateKnowledgeBase")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于创建新的问答对。问答对可以在SearchKnowledge接口知识检索时提供匹配的答案。 使用场景：当需要添加新的知识点和对应的问答对时使用，比如为产品添加新的常见问题解答。
        /// </summary>
        /// <param name="req"><see cref="CreateQARequest"/></param>
        /// <returns><see cref="CreateQAResponse"/></returns>
        public Task<CreateQAResponse> CreateQA(CreateQARequest req)
        {
            return InternalRequestAsync<CreateQAResponse>(req, "CreateQA");
        }

        /// <summary>
        /// 用于创建新的问答对。问答对可以在SearchKnowledge接口知识检索时提供匹配的答案。 使用场景：当需要添加新的知识点和对应的问答对时使用，比如为产品添加新的常见问题解答。
        /// </summary>
        /// <param name="req"><see cref="CreateQARequest"/></param>
        /// <returns><see cref="CreateQAResponse"/></returns>
        public CreateQAResponse CreateQASync(CreateQARequest req)
        {
            return InternalRequestAsync<CreateQAResponse>(req, "CreateQA")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口为异步接口的发起请求接口，用于发起文档解析任务。
        /// 文档解析支持将图片或PDF文件转换成Markdown格式文件，可解析包括表格、公式、图片、标题、段落、页眉、页脚等内容元素，并将内容智能转换成阅读顺序。
        /// 
        /// 体验期间单账号限制qps仅为1，若有正式接入需要请与产研团队沟通开放。
        /// </summary>
        /// <param name="req"><see cref="CreateReconstructDocumentFlowRequest"/></param>
        /// <returns><see cref="CreateReconstructDocumentFlowResponse"/></returns>
        public Task<CreateReconstructDocumentFlowResponse> CreateReconstructDocumentFlow(CreateReconstructDocumentFlowRequest req)
        {
            return InternalRequestAsync<CreateReconstructDocumentFlowResponse>(req, "CreateReconstructDocumentFlow");
        }

        /// <summary>
        /// 本接口为异步接口的发起请求接口，用于发起文档解析任务。
        /// 文档解析支持将图片或PDF文件转换成Markdown格式文件，可解析包括表格、公式、图片、标题、段落、页眉、页脚等内容元素，并将内容智能转换成阅读顺序。
        /// 
        /// 体验期间单账号限制qps仅为1，若有正式接入需要请与产研团队沟通开放。
        /// </summary>
        /// <param name="req"><see cref="CreateReconstructDocumentFlowRequest"/></param>
        /// <returns><see cref="CreateReconstructDocumentFlowResponse"/></returns>
        public CreateReconstructDocumentFlowResponse CreateReconstructDocumentFlowSync(CreateReconstructDocumentFlowRequest req)
        {
            return InternalRequestAsync<CreateReconstructDocumentFlowResponse>(req, "CreateReconstructDocumentFlow")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于创建一个文档拆分任务，支持多种文件类型，具备mllm能力，能够解析并深入理解图表中的信息。
        /// </summary>
        /// <param name="req"><see cref="CreateSplitDocumentFlowRequest"/></param>
        /// <returns><see cref="CreateSplitDocumentFlowResponse"/></returns>
        public Task<CreateSplitDocumentFlowResponse> CreateSplitDocumentFlow(CreateSplitDocumentFlowRequest req)
        {
            return InternalRequestAsync<CreateSplitDocumentFlowResponse>(req, "CreateSplitDocumentFlow");
        }

        /// <summary>
        /// 用于创建一个文档拆分任务，支持多种文件类型，具备mllm能力，能够解析并深入理解图表中的信息。
        /// </summary>
        /// <param name="req"><see cref="CreateSplitDocumentFlowRequest"/></param>
        /// <returns><see cref="CreateSplitDocumentFlowResponse"/></returns>
        public CreateSplitDocumentFlowResponse CreateSplitDocumentFlowSync(CreateSplitDocumentFlowRequest req)
        {
            return InternalRequestAsync<CreateSplitDocumentFlowResponse>(req, "CreateSplitDocumentFlow")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于删除不再需要的属性标签。 使用场景：当某个标签不再使用时，可以将其删除以保持标签系统的整洁。
        /// </summary>
        /// <param name="req"><see cref="DeleteAttributeLabelsRequest"/></param>
        /// <returns><see cref="DeleteAttributeLabelsResponse"/></returns>
        public Task<DeleteAttributeLabelsResponse> DeleteAttributeLabels(DeleteAttributeLabelsRequest req)
        {
            return InternalRequestAsync<DeleteAttributeLabelsResponse>(req, "DeleteAttributeLabels");
        }

        /// <summary>
        /// 用于删除不再需要的属性标签。 使用场景：当某个标签不再使用时，可以将其删除以保持标签系统的整洁。
        /// </summary>
        /// <param name="req"><see cref="DeleteAttributeLabelsRequest"/></param>
        /// <returns><see cref="DeleteAttributeLabelsResponse"/></returns>
        public DeleteAttributeLabelsResponse DeleteAttributeLabelsSync(DeleteAttributeLabelsRequest req)
        {
            return InternalRequestAsync<DeleteAttributeLabelsResponse>(req, "DeleteAttributeLabels")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于删除已有的文档。 使用场景：当某个文档不再需要时，可以将其删除以保持文档库的整洁。
        /// </summary>
        /// <param name="req"><see cref="DeleteDocsRequest"/></param>
        /// <returns><see cref="DeleteDocsResponse"/></returns>
        public Task<DeleteDocsResponse> DeleteDocs(DeleteDocsRequest req)
        {
            return InternalRequestAsync<DeleteDocsResponse>(req, "DeleteDocs");
        }

        /// <summary>
        /// 用于删除已有的文档。 使用场景：当某个文档不再需要时，可以将其删除以保持文档库的整洁。
        /// </summary>
        /// <param name="req"><see cref="DeleteDocsRequest"/></param>
        /// <returns><see cref="DeleteDocsResponse"/></returns>
        public DeleteDocsResponse DeleteDocsSync(DeleteDocsRequest req)
        {
            return InternalRequestAsync<DeleteDocsResponse>(req, "DeleteDocs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于从系统中删除一个现有的知识库。删除知识库将移除该知识库及其所有关联的知识条目（如文档、问答对、属性标签等）。该操作是不可逆的，请在执行前确认是否需要删除。**使用场景**：当某个知识库不再需要时，可以使用此接口将其从系统中删除。例如，一个项目结束后，其相关的知识库可能不再需要存储，可以使用该接口进行删除。
        /// </summary>
        /// <param name="req"><see cref="DeleteKnowledgeBaseRequest"/></param>
        /// <returns><see cref="DeleteKnowledgeBaseResponse"/></returns>
        public Task<DeleteKnowledgeBaseResponse> DeleteKnowledgeBase(DeleteKnowledgeBaseRequest req)
        {
            return InternalRequestAsync<DeleteKnowledgeBaseResponse>(req, "DeleteKnowledgeBase");
        }

        /// <summary>
        /// 用于从系统中删除一个现有的知识库。删除知识库将移除该知识库及其所有关联的知识条目（如文档、问答对、属性标签等）。该操作是不可逆的，请在执行前确认是否需要删除。**使用场景**：当某个知识库不再需要时，可以使用此接口将其从系统中删除。例如，一个项目结束后，其相关的知识库可能不再需要存储，可以使用该接口进行删除。
        /// </summary>
        /// <param name="req"><see cref="DeleteKnowledgeBaseRequest"/></param>
        /// <returns><see cref="DeleteKnowledgeBaseResponse"/></returns>
        public DeleteKnowledgeBaseResponse DeleteKnowledgeBaseSync(DeleteKnowledgeBaseRequest req)
        {
            return InternalRequestAsync<DeleteKnowledgeBaseResponse>(req, "DeleteKnowledgeBase")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于删除已有的问答对。 使用场景：当某个问答对不再适用或需要移除时使用。
        /// </summary>
        /// <param name="req"><see cref="DeleteQAsRequest"/></param>
        /// <returns><see cref="DeleteQAsResponse"/></returns>
        public Task<DeleteQAsResponse> DeleteQAs(DeleteQAsRequest req)
        {
            return InternalRequestAsync<DeleteQAsResponse>(req, "DeleteQAs");
        }

        /// <summary>
        /// 用于删除已有的问答对。 使用场景：当某个问答对不再适用或需要移除时使用。
        /// </summary>
        /// <param name="req"><see cref="DeleteQAsRequest"/></param>
        /// <returns><see cref="DeleteQAsResponse"/></returns>
        public DeleteQAsResponse DeleteQAsSync(DeleteQAsRequest req)
        {
            return InternalRequestAsync<DeleteQAsResponse>(req, "DeleteQAs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于查询特定文档的详细信息。 使用场景：当需要查看某个文档的具体内容和属性时使用。
        /// </summary>
        /// <param name="req"><see cref="DescribeDocRequest"/></param>
        /// <returns><see cref="DescribeDocResponse"/></returns>
        public Task<DescribeDocResponse> DescribeDoc(DescribeDocRequest req)
        {
            return InternalRequestAsync<DescribeDocResponse>(req, "DescribeDoc");
        }

        /// <summary>
        /// 用于查询特定文档的详细信息。 使用场景：当需要查看某个文档的具体内容和属性时使用。
        /// </summary>
        /// <param name="req"><see cref="DescribeDocRequest"/></param>
        /// <returns><see cref="DescribeDocResponse"/></returns>
        public DescribeDocResponse DescribeDocSync(DescribeDocRequest req)
        {
            return InternalRequestAsync<DescribeDocResponse>(req, "DescribeDoc")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（GetEmbedding）调用文本表示模型，将文本转化为用数值表示的向量形式，可用于文本检索、信息推荐、知识挖掘等场景。
        /// 本接口（GetEmbedding）有单账号调用上限控制，如您有提高并发限制的需求请 [联系我们](https://cloud.tencent.com/act/event/Online_service) 。
        /// </summary>
        /// <param name="req"><see cref="GetEmbeddingRequest"/></param>
        /// <returns><see cref="GetEmbeddingResponse"/></returns>
        public Task<GetEmbeddingResponse> GetEmbedding(GetEmbeddingRequest req)
        {
            return InternalRequestAsync<GetEmbeddingResponse>(req, "GetEmbedding");
        }

        /// <summary>
        /// 本接口（GetEmbedding）调用文本表示模型，将文本转化为用数值表示的向量形式，可用于文本检索、信息推荐、知识挖掘等场景。
        /// 本接口（GetEmbedding）有单账号调用上限控制，如您有提高并发限制的需求请 [联系我们](https://cloud.tencent.com/act/event/Online_service) 。
        /// </summary>
        /// <param name="req"><see cref="GetEmbeddingRequest"/></param>
        /// <returns><see cref="GetEmbeddingResponse"/></returns>
        public GetEmbeddingResponse GetEmbeddingSync(GetEmbeddingRequest req)
        {
            return InternalRequestAsync<GetEmbeddingResponse>(req, "GetEmbedding")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口为异步接口的查询结果接口，用于获取文档解析处理结果。
        /// </summary>
        /// <param name="req"><see cref="GetReconstructDocumentResultRequest"/></param>
        /// <returns><see cref="GetReconstructDocumentResultResponse"/></returns>
        public Task<GetReconstructDocumentResultResponse> GetReconstructDocumentResult(GetReconstructDocumentResultRequest req)
        {
            return InternalRequestAsync<GetReconstructDocumentResultResponse>(req, "GetReconstructDocumentResult");
        }

        /// <summary>
        /// 本接口为异步接口的查询结果接口，用于获取文档解析处理结果。
        /// </summary>
        /// <param name="req"><see cref="GetReconstructDocumentResultRequest"/></param>
        /// <returns><see cref="GetReconstructDocumentResultResponse"/></returns>
        public GetReconstructDocumentResultResponse GetReconstructDocumentResultSync(GetReconstructDocumentResultRequest req)
        {
            return InternalRequestAsync<GetReconstructDocumentResultResponse>(req, "GetReconstructDocumentResult")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询文档拆分任务结果
        /// </summary>
        /// <param name="req"><see cref="GetSplitDocumentResultRequest"/></param>
        /// <returns><see cref="GetSplitDocumentResultResponse"/></returns>
        public Task<GetSplitDocumentResultResponse> GetSplitDocumentResult(GetSplitDocumentResultRequest req)
        {
            return InternalRequestAsync<GetSplitDocumentResultResponse>(req, "GetSplitDocumentResult");
        }

        /// <summary>
        /// 查询文档拆分任务结果
        /// </summary>
        /// <param name="req"><see cref="GetSplitDocumentResultRequest"/></param>
        /// <returns><see cref="GetSplitDocumentResultResponse"/></returns>
        public GetSplitDocumentResultResponse GetSplitDocumentResultSync(GetSplitDocumentResultRequest req)
        {
            return InternalRequestAsync<GetSplitDocumentResultResponse>(req, "GetSplitDocumentResult")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于批量导入问答对，最多支持50,000条数据导入。通过此接口，可以将多个问答对一次性导入系统中，以便在后续的知识检索中使用。导入的问答对可以来自外部系统、文件或其他数据源。使用场景：当需要一次性导入大量的问答对时使用。例如，一个公司可能需要将其产品的常见问题解答从一个文档或外部系统批量导入到知识库中，以便用户可以通过知识检索系统进行查询。
        /// </summary>
        /// <param name="req"><see cref="ImportQAsRequest"/></param>
        /// <returns><see cref="ImportQAsResponse"/></returns>
        public Task<ImportQAsResponse> ImportQAs(ImportQAsRequest req)
        {
            return InternalRequestAsync<ImportQAsResponse>(req, "ImportQAs");
        }

        /// <summary>
        /// 用于批量导入问答对，最多支持50,000条数据导入。通过此接口，可以将多个问答对一次性导入系统中，以便在后续的知识检索中使用。导入的问答对可以来自外部系统、文件或其他数据源。使用场景：当需要一次性导入大量的问答对时使用。例如，一个公司可能需要将其产品的常见问题解答从一个文档或外部系统批量导入到知识库中，以便用户可以通过知识检索系统进行查询。
        /// </summary>
        /// <param name="req"><see cref="ImportQAsRequest"/></param>
        /// <returns><see cref="ImportQAsResponse"/></returns>
        public ImportQAsResponse ImportQAsSync(ImportQAsRequest req)
        {
            return InternalRequestAsync<ImportQAsResponse>(req, "ImportQAs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于获取所有属性标签的列表。 使用场景：用于查看当前系统中所有已有的属性标签，方便进行管理和维护。
        /// </summary>
        /// <param name="req"><see cref="ListAttributeLabelsRequest"/></param>
        /// <returns><see cref="ListAttributeLabelsResponse"/></returns>
        public Task<ListAttributeLabelsResponse> ListAttributeLabels(ListAttributeLabelsRequest req)
        {
            return InternalRequestAsync<ListAttributeLabelsResponse>(req, "ListAttributeLabels");
        }

        /// <summary>
        /// 用于获取所有属性标签的列表。 使用场景：用于查看当前系统中所有已有的属性标签，方便进行管理和维护。
        /// </summary>
        /// <param name="req"><see cref="ListAttributeLabelsRequest"/></param>
        /// <returns><see cref="ListAttributeLabelsResponse"/></returns>
        public ListAttributeLabelsResponse ListAttributeLabelsSync(ListAttributeLabelsRequest req)
        {
            return InternalRequestAsync<ListAttributeLabelsResponse>(req, "ListAttributeLabels")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于获取所有文档的列表。 使用场景：用于查看当前系统中所有已有的文档，方便进行管理和维护。
        /// </summary>
        /// <param name="req"><see cref="ListDocsRequest"/></param>
        /// <returns><see cref="ListDocsResponse"/></returns>
        public Task<ListDocsResponse> ListDocs(ListDocsRequest req)
        {
            return InternalRequestAsync<ListDocsResponse>(req, "ListDocs");
        }

        /// <summary>
        /// 用于获取所有文档的列表。 使用场景：用于查看当前系统中所有已有的文档，方便进行管理和维护。
        /// </summary>
        /// <param name="req"><see cref="ListDocsRequest"/></param>
        /// <returns><see cref="ListDocsResponse"/></returns>
        public ListDocsResponse ListDocsSync(ListDocsRequest req)
        {
            return InternalRequestAsync<ListDocsResponse>(req, "ListDocs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于获取所有问答对的列表。 使用场景：用于查看当前系统中所有已有的问答对，方便进行管理和维护。
        /// </summary>
        /// <param name="req"><see cref="ListQAsRequest"/></param>
        /// <returns><see cref="ListQAsResponse"/></returns>
        public Task<ListQAsResponse> ListQAs(ListQAsRequest req)
        {
            return InternalRequestAsync<ListQAsResponse>(req, "ListQAs");
        }

        /// <summary>
        /// 用于获取所有问答对的列表。 使用场景：用于查看当前系统中所有已有的问答对，方便进行管理和维护。
        /// </summary>
        /// <param name="req"><see cref="ListQAsRequest"/></param>
        /// <returns><see cref="ListQAsResponse"/></returns>
        public ListQAsResponse ListQAsSync(ListQAsRequest req)
        {
            return InternalRequestAsync<ListQAsResponse>(req, "ListQAs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于修改已有的属性标签。 使用场景：当需要更改属性标签的名称或描述时使用，比如将“售后”标签改为“售前”。
        /// </summary>
        /// <param name="req"><see cref="ModifyAttributeLabelRequest"/></param>
        /// <returns><see cref="ModifyAttributeLabelResponse"/></returns>
        public Task<ModifyAttributeLabelResponse> ModifyAttributeLabel(ModifyAttributeLabelRequest req)
        {
            return InternalRequestAsync<ModifyAttributeLabelResponse>(req, "ModifyAttributeLabel");
        }

        /// <summary>
        /// 用于修改已有的属性标签。 使用场景：当需要更改属性标签的名称或描述时使用，比如将“售后”标签改为“售前”。
        /// </summary>
        /// <param name="req"><see cref="ModifyAttributeLabelRequest"/></param>
        /// <returns><see cref="ModifyAttributeLabelResponse"/></returns>
        public ModifyAttributeLabelResponse ModifyAttributeLabelSync(ModifyAttributeLabelRequest req)
        {
            return InternalRequestAsync<ModifyAttributeLabelResponse>(req, "ModifyAttributeLabel")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于修改已有的问答对。 使用场景：当需要更新问答对的内容或答案时使用。
        /// </summary>
        /// <param name="req"><see cref="ModifyQARequest"/></param>
        /// <returns><see cref="ModifyQAResponse"/></returns>
        public Task<ModifyQAResponse> ModifyQA(ModifyQARequest req)
        {
            return InternalRequestAsync<ModifyQAResponse>(req, "ModifyQA");
        }

        /// <summary>
        /// 用于修改已有的问答对。 使用场景：当需要更新问答对的内容或答案时使用。
        /// </summary>
        /// <param name="req"><see cref="ModifyQARequest"/></param>
        /// <returns><see cref="ModifyQAResponse"/></returns>
        public ModifyQAResponse ModifyQASync(ModifyQARequest req)
        {
            return InternalRequestAsync<ModifyQAResponse>(req, "ModifyQA")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 多轮改写（QueryRewrite）主要用于多轮对话中，进行指代消解和省略补全。使用本接口，无需输入prompt描述，根据对话历史即可生成更精确的用户查询。在应用场景上，本接口可应用于智能问答、对话式搜索等多种场景。
        /// 开通[产品体验](https://lke.cloud.tencent.com/lke/#/trialProduct)后可获得50wtoken体验额度。本接口（QueryRewrite）有单账号调用上限控制，如您有提高并发限制的需求请 [联系我们](https://cloud.tencent.com/act/event/Online_service) 。
        /// </summary>
        /// <param name="req"><see cref="QueryRewriteRequest"/></param>
        /// <returns><see cref="QueryRewriteResponse"/></returns>
        public Task<QueryRewriteResponse> QueryRewrite(QueryRewriteRequest req)
        {
            return InternalRequestAsync<QueryRewriteResponse>(req, "QueryRewrite");
        }

        /// <summary>
        /// 多轮改写（QueryRewrite）主要用于多轮对话中，进行指代消解和省略补全。使用本接口，无需输入prompt描述，根据对话历史即可生成更精确的用户查询。在应用场景上，本接口可应用于智能问答、对话式搜索等多种场景。
        /// 开通[产品体验](https://lke.cloud.tencent.com/lke/#/trialProduct)后可获得50wtoken体验额度。本接口（QueryRewrite）有单账号调用上限控制，如您有提高并发限制的需求请 [联系我们](https://cloud.tencent.com/act/event/Online_service) 。
        /// </summary>
        /// <param name="req"><see cref="QueryRewriteRequest"/></param>
        /// <returns><see cref="QueryRewriteResponse"/></returns>
        public QueryRewriteResponse QueryRewriteSync(QueryRewriteRequest req)
        {
            return InternalRequestAsync<QueryRewriteResponse>(req, "QueryRewrite")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 准实时文档解析接口，使用HTTP SSE 协议通信。
        /// </summary>
        /// <param name="req"><see cref="ReconstructDocumentSSERequest"/></param>
        /// <returns><see cref="ReconstructDocumentSSEResponse"/></returns>
        public Task<ReconstructDocumentSSEResponse> ReconstructDocumentSSE(ReconstructDocumentSSERequest req)
        {
            return InternalRequestAsync<ReconstructDocumentSSEResponse>(req, "ReconstructDocumentSSE");
        }

        /// <summary>
        /// 准实时文档解析接口，使用HTTP SSE 协议通信。
        /// </summary>
        /// <param name="req"><see cref="ReconstructDocumentSSERequest"/></param>
        /// <returns><see cref="ReconstructDocumentSSEResponse"/></returns>
        public ReconstructDocumentSSEResponse ReconstructDocumentSSESync(ReconstructDocumentSSERequest req)
        {
            return InternalRequestAsync<ReconstructDocumentSSEResponse>(req, "ReconstructDocumentSSE")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于检索知识库中的文档和问答对内容。 使用场景：适用于查询长期存储在知识库中的文档和问答对，比如产品手册、用户指南等内容的检索。
        /// </summary>
        /// <param name="req"><see cref="RetrieveKnowledgeRequest"/></param>
        /// <returns><see cref="RetrieveKnowledgeResponse"/></returns>
        public Task<RetrieveKnowledgeResponse> RetrieveKnowledge(RetrieveKnowledgeRequest req)
        {
            return InternalRequestAsync<RetrieveKnowledgeResponse>(req, "RetrieveKnowledge");
        }

        /// <summary>
        /// 用于检索知识库中的文档和问答对内容。 使用场景：适用于查询长期存储在知识库中的文档和问答对，比如产品手册、用户指南等内容的检索。
        /// </summary>
        /// <param name="req"><see cref="RetrieveKnowledgeRequest"/></param>
        /// <returns><see cref="RetrieveKnowledgeResponse"/></returns>
        public RetrieveKnowledgeResponse RetrieveKnowledgeSync(RetrieveKnowledgeRequest req)
        {
            return InternalRequestAsync<RetrieveKnowledgeResponse>(req, "RetrieveKnowledge")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 基于知识引擎精调模型技术的rerank模型，支持对多路召回的结果进行重排序，根据query与切片内容的相关性，按分数由高到低对切片进行排序，并输出对应的打分结果。
        /// </summary>
        /// <param name="req"><see cref="RunRerankRequest"/></param>
        /// <returns><see cref="RunRerankResponse"/></returns>
        public Task<RunRerankResponse> RunRerank(RunRerankRequest req)
        {
            return InternalRequestAsync<RunRerankResponse>(req, "RunRerank");
        }

        /// <summary>
        /// 基于知识引擎精调模型技术的rerank模型，支持对多路召回的结果进行重排序，根据query与切片内容的相关性，按分数由高到低对切片进行排序，并输出对应的打分结果。
        /// </summary>
        /// <param name="req"><see cref="RunRerankRequest"/></param>
        /// <returns><see cref="RunRerankResponse"/></returns>
        public RunRerankResponse RunRerankSync(RunRerankRequest req)
        {
            return InternalRequestAsync<RunRerankResponse>(req, "RunRerank")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于上传文档内容。上传的文档将存储在知识库中，可以通过SearchKnowledge知识库内容检索接口进行检索。 
        /// 使用场景：适用于需要长期存储和检索的文档内容，如产品手册、用户指南等。
        /// </summary>
        /// <param name="req"><see cref="UploadDocRequest"/></param>
        /// <returns><see cref="UploadDocResponse"/></returns>
        public Task<UploadDocResponse> UploadDoc(UploadDocRequest req)
        {
            return InternalRequestAsync<UploadDocResponse>(req, "UploadDoc");
        }

        /// <summary>
        /// 用于上传文档内容。上传的文档将存储在知识库中，可以通过SearchKnowledge知识库内容检索接口进行检索。 
        /// 使用场景：适用于需要长期存储和检索的文档内容，如产品手册、用户指南等。
        /// </summary>
        /// <param name="req"><see cref="UploadDocRequest"/></param>
        /// <returns><see cref="UploadDocResponse"/></returns>
        public UploadDocResponse UploadDocSync(UploadDocRequest req)
        {
            return InternalRequestAsync<UploadDocResponse>(req, "UploadDoc")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于上传实时文档内容。实时文档在上传后可以立即通过SearchRealtime进行实时检索，适用于在会话中对文档进行问答的场景。
        /// </summary>
        /// <param name="req"><see cref="UploadDocRealtimeRequest"/></param>
        /// <returns><see cref="UploadDocRealtimeResponse"/></returns>
        public Task<UploadDocRealtimeResponse> UploadDocRealtime(UploadDocRealtimeRequest req)
        {
            return InternalRequestAsync<UploadDocRealtimeResponse>(req, "UploadDocRealtime");
        }

        /// <summary>
        /// 用于上传实时文档内容。实时文档在上传后可以立即通过SearchRealtime进行实时检索，适用于在会话中对文档进行问答的场景。
        /// </summary>
        /// <param name="req"><see cref="UploadDocRealtimeRequest"/></param>
        /// <returns><see cref="UploadDocRealtimeResponse"/></returns>
        public UploadDocRealtimeResponse UploadDocRealtimeSync(UploadDocRealtimeRequest req)
        {
            return InternalRequestAsync<UploadDocRealtimeResponse>(req, "UploadDocRealtime")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
