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

namespace TencentCloud.Lke.V20231130
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Lke.V20231130.Models;

   public class LkeClient : AbstractClient{

       private const string endpoint = "lke.tencentcloudapi.com";
       private const string version = "2023-11-30";
       private const string sdkVersion = "SDK_NET_3.0.1222";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public LkeClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public LkeClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 检查属性下的标签名是否存在
        /// </summary>
        /// <param name="req"><see cref="CheckAttributeLabelExistRequest"/></param>
        /// <returns><see cref="CheckAttributeLabelExistResponse"/></returns>
        public Task<CheckAttributeLabelExistResponse> CheckAttributeLabelExist(CheckAttributeLabelExistRequest req)
        {
            return InternalRequestAsync<CheckAttributeLabelExistResponse>(req, "CheckAttributeLabelExist");
        }

        /// <summary>
        /// 检查属性下的标签名是否存在
        /// </summary>
        /// <param name="req"><see cref="CheckAttributeLabelExistRequest"/></param>
        /// <returns><see cref="CheckAttributeLabelExistResponse"/></returns>
        public CheckAttributeLabelExistResponse CheckAttributeLabelExistSync(CheckAttributeLabelExistRequest req)
        {
            return InternalRequestAsync<CheckAttributeLabelExistResponse>(req, "CheckAttributeLabelExist")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 检查属性标签引用
        /// </summary>
        /// <param name="req"><see cref="CheckAttributeLabelReferRequest"/></param>
        /// <returns><see cref="CheckAttributeLabelReferResponse"/></returns>
        public Task<CheckAttributeLabelReferResponse> CheckAttributeLabelRefer(CheckAttributeLabelReferRequest req)
        {
            return InternalRequestAsync<CheckAttributeLabelReferResponse>(req, "CheckAttributeLabelRefer");
        }

        /// <summary>
        /// 检查属性标签引用
        /// </summary>
        /// <param name="req"><see cref="CheckAttributeLabelReferRequest"/></param>
        /// <returns><see cref="CheckAttributeLabelReferResponse"/></returns>
        public CheckAttributeLabelReferResponse CheckAttributeLabelReferSync(CheckAttributeLabelReferRequest req)
        {
            return InternalRequestAsync<CheckAttributeLabelReferResponse>(req, "CheckAttributeLabelRefer")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 产品规划
        /// 
        /// 接口支持图片和PDF转可编辑word格式文件，将文件中的图片、文本、表格等元素识别，并根据位置进行还原。
        /// </summary>
        /// <param name="req"><see cref="ConvertDocumentRequest"/></param>
        /// <returns><see cref="ConvertDocumentResponse"/></returns>
        public Task<ConvertDocumentResponse> ConvertDocument(ConvertDocumentRequest req)
        {
            return InternalRequestAsync<ConvertDocumentResponse>(req, "ConvertDocument");
        }

        /// <summary>
        /// 产品规划
        /// 
        /// 接口支持图片和PDF转可编辑word格式文件，将文件中的图片、文本、表格等元素识别，并根据位置进行还原。
        /// </summary>
        /// <param name="req"><see cref="ConvertDocumentRequest"/></param>
        /// <returns><see cref="ConvertDocumentResponse"/></returns>
        public ConvertDocumentResponse ConvertDocumentSync(ConvertDocumentRequest req)
        {
            return InternalRequestAsync<ConvertDocumentResponse>(req, "ConvertDocument")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建知识引擎应用。
        /// </summary>
        /// <param name="req"><see cref="CreateAppRequest"/></param>
        /// <returns><see cref="CreateAppResponse"/></returns>
        public Task<CreateAppResponse> CreateApp(CreateAppRequest req)
        {
            return InternalRequestAsync<CreateAppResponse>(req, "CreateApp");
        }

        /// <summary>
        /// 创建知识引擎应用。
        /// </summary>
        /// <param name="req"><see cref="CreateAppRequest"/></param>
        /// <returns><see cref="CreateAppResponse"/></returns>
        public CreateAppResponse CreateAppSync(CreateAppRequest req)
        {
            return InternalRequestAsync<CreateAppResponse>(req, "CreateApp")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建标签
        /// </summary>
        /// <param name="req"><see cref="CreateAttributeLabelRequest"/></param>
        /// <returns><see cref="CreateAttributeLabelResponse"/></returns>
        public Task<CreateAttributeLabelResponse> CreateAttributeLabel(CreateAttributeLabelRequest req)
        {
            return InternalRequestAsync<CreateAttributeLabelResponse>(req, "CreateAttributeLabel");
        }

        /// <summary>
        /// 创建标签
        /// </summary>
        /// <param name="req"><see cref="CreateAttributeLabelRequest"/></param>
        /// <returns><see cref="CreateAttributeLabelResponse"/></returns>
        public CreateAttributeLabelResponse CreateAttributeLabelSync(CreateAttributeLabelRequest req)
        {
            return InternalRequestAsync<CreateAttributeLabelResponse>(req, "CreateAttributeLabel")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建企业
        /// </summary>
        /// <param name="req"><see cref="CreateCorpRequest"/></param>
        /// <returns><see cref="CreateCorpResponse"/></returns>
        public Task<CreateCorpResponse> CreateCorp(CreateCorpRequest req)
        {
            return InternalRequestAsync<CreateCorpResponse>(req, "CreateCorp");
        }

        /// <summary>
        /// 创建企业
        /// </summary>
        /// <param name="req"><see cref="CreateCorpRequest"/></param>
        /// <returns><see cref="CreateCorpResponse"/></returns>
        public CreateCorpResponse CreateCorpSync(CreateCorpRequest req)
        {
            return InternalRequestAsync<CreateCorpResponse>(req, "CreateCorp")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建Doc分类
        /// </summary>
        /// <param name="req"><see cref="CreateDocCateRequest"/></param>
        /// <returns><see cref="CreateDocCateResponse"/></returns>
        public Task<CreateDocCateResponse> CreateDocCate(CreateDocCateRequest req)
        {
            return InternalRequestAsync<CreateDocCateResponse>(req, "CreateDocCate");
        }

        /// <summary>
        /// 创建Doc分类
        /// </summary>
        /// <param name="req"><see cref="CreateDocCateRequest"/></param>
        /// <returns><see cref="CreateDocCateResponse"/></returns>
        public CreateDocCateResponse CreateDocCateSync(CreateDocCateRequest req)
        {
            return InternalRequestAsync<CreateDocCateResponse>(req, "CreateDocCate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 录入问答
        /// </summary>
        /// <param name="req"><see cref="CreateQARequest"/></param>
        /// <returns><see cref="CreateQAResponse"/></returns>
        public Task<CreateQAResponse> CreateQA(CreateQARequest req)
        {
            return InternalRequestAsync<CreateQAResponse>(req, "CreateQA");
        }

        /// <summary>
        /// 录入问答
        /// </summary>
        /// <param name="req"><see cref="CreateQARequest"/></param>
        /// <returns><see cref="CreateQAResponse"/></returns>
        public CreateQAResponse CreateQASync(CreateQARequest req)
        {
            return InternalRequestAsync<CreateQAResponse>(req, "CreateQA")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建QA分类
        /// </summary>
        /// <param name="req"><see cref="CreateQACateRequest"/></param>
        /// <returns><see cref="CreateQACateResponse"/></returns>
        public Task<CreateQACateResponse> CreateQACate(CreateQACateRequest req)
        {
            return InternalRequestAsync<CreateQACateResponse>(req, "CreateQACate");
        }

        /// <summary>
        /// 创建QA分类
        /// </summary>
        /// <param name="req"><see cref="CreateQACateRequest"/></param>
        /// <returns><see cref="CreateQACateResponse"/></returns>
        public CreateQACateResponse CreateQACateSync(CreateQACateRequest req)
        {
            return InternalRequestAsync<CreateQACateResponse>(req, "CreateQACate")
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
        /// 创建拒答问题
        /// </summary>
        /// <param name="req"><see cref="CreateRejectedQuestionRequest"/></param>
        /// <returns><see cref="CreateRejectedQuestionResponse"/></returns>
        public Task<CreateRejectedQuestionResponse> CreateRejectedQuestion(CreateRejectedQuestionRequest req)
        {
            return InternalRequestAsync<CreateRejectedQuestionResponse>(req, "CreateRejectedQuestion");
        }

        /// <summary>
        /// 创建拒答问题
        /// </summary>
        /// <param name="req"><see cref="CreateRejectedQuestionRequest"/></param>
        /// <returns><see cref="CreateRejectedQuestionResponse"/></returns>
        public CreateRejectedQuestionResponse CreateRejectedQuestionSync(CreateRejectedQuestionRequest req)
        {
            return InternalRequestAsync<CreateRejectedQuestionResponse>(req, "CreateRejectedQuestion")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建发布
        /// </summary>
        /// <param name="req"><see cref="CreateReleaseRequest"/></param>
        /// <returns><see cref="CreateReleaseResponse"/></returns>
        public Task<CreateReleaseResponse> CreateRelease(CreateReleaseRequest req)
        {
            return InternalRequestAsync<CreateReleaseResponse>(req, "CreateRelease");
        }

        /// <summary>
        /// 创建发布
        /// </summary>
        /// <param name="req"><see cref="CreateReleaseRequest"/></param>
        /// <returns><see cref="CreateReleaseResponse"/></returns>
        public CreateReleaseResponse CreateReleaseSync(CreateReleaseRequest req)
        {
            return InternalRequestAsync<CreateReleaseResponse>(req, "CreateRelease")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建变量
        /// </summary>
        /// <param name="req"><see cref="CreateVarRequest"/></param>
        /// <returns><see cref="CreateVarResponse"/></returns>
        public Task<CreateVarResponse> CreateVar(CreateVarRequest req)
        {
            return InternalRequestAsync<CreateVarResponse>(req, "CreateVar");
        }

        /// <summary>
        /// 创建变量
        /// </summary>
        /// <param name="req"><see cref="CreateVarRequest"/></param>
        /// <returns><see cref="CreateVarResponse"/></returns>
        public CreateVarResponse CreateVarSync(CreateVarRequest req)
        {
            return InternalRequestAsync<CreateVarResponse>(req, "CreateVar")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除应用
        /// </summary>
        /// <param name="req"><see cref="DeleteAppRequest"/></param>
        /// <returns><see cref="DeleteAppResponse"/></returns>
        public Task<DeleteAppResponse> DeleteApp(DeleteAppRequest req)
        {
            return InternalRequestAsync<DeleteAppResponse>(req, "DeleteApp");
        }

        /// <summary>
        /// 删除应用
        /// </summary>
        /// <param name="req"><see cref="DeleteAppRequest"/></param>
        /// <returns><see cref="DeleteAppResponse"/></returns>
        public DeleteAppResponse DeleteAppSync(DeleteAppRequest req)
        {
            return InternalRequestAsync<DeleteAppResponse>(req, "DeleteApp")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除属性标签
        /// </summary>
        /// <param name="req"><see cref="DeleteAttributeLabelRequest"/></param>
        /// <returns><see cref="DeleteAttributeLabelResponse"/></returns>
        public Task<DeleteAttributeLabelResponse> DeleteAttributeLabel(DeleteAttributeLabelRequest req)
        {
            return InternalRequestAsync<DeleteAttributeLabelResponse>(req, "DeleteAttributeLabel");
        }

        /// <summary>
        /// 删除属性标签
        /// </summary>
        /// <param name="req"><see cref="DeleteAttributeLabelRequest"/></param>
        /// <returns><see cref="DeleteAttributeLabelResponse"/></returns>
        public DeleteAttributeLabelResponse DeleteAttributeLabelSync(DeleteAttributeLabelRequest req)
        {
            return InternalRequestAsync<DeleteAttributeLabelResponse>(req, "DeleteAttributeLabel")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除文档
        /// </summary>
        /// <param name="req"><see cref="DeleteDocRequest"/></param>
        /// <returns><see cref="DeleteDocResponse"/></returns>
        public Task<DeleteDocResponse> DeleteDoc(DeleteDocRequest req)
        {
            return InternalRequestAsync<DeleteDocResponse>(req, "DeleteDoc");
        }

        /// <summary>
        /// 删除文档
        /// </summary>
        /// <param name="req"><see cref="DeleteDocRequest"/></param>
        /// <returns><see cref="DeleteDocResponse"/></returns>
        public DeleteDocResponse DeleteDocSync(DeleteDocRequest req)
        {
            return InternalRequestAsync<DeleteDocResponse>(req, "DeleteDoc")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Doc分类删除
        /// </summary>
        /// <param name="req"><see cref="DeleteDocCateRequest"/></param>
        /// <returns><see cref="DeleteDocCateResponse"/></returns>
        public Task<DeleteDocCateResponse> DeleteDocCate(DeleteDocCateRequest req)
        {
            return InternalRequestAsync<DeleteDocCateResponse>(req, "DeleteDocCate");
        }

        /// <summary>
        /// Doc分类删除
        /// </summary>
        /// <param name="req"><see cref="DeleteDocCateRequest"/></param>
        /// <returns><see cref="DeleteDocCateResponse"/></returns>
        public DeleteDocCateResponse DeleteDocCateSync(DeleteDocCateRequest req)
        {
            return InternalRequestAsync<DeleteDocCateResponse>(req, "DeleteDocCate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除问答
        /// </summary>
        /// <param name="req"><see cref="DeleteQARequest"/></param>
        /// <returns><see cref="DeleteQAResponse"/></returns>
        public Task<DeleteQAResponse> DeleteQA(DeleteQARequest req)
        {
            return InternalRequestAsync<DeleteQAResponse>(req, "DeleteQA");
        }

        /// <summary>
        /// 删除问答
        /// </summary>
        /// <param name="req"><see cref="DeleteQARequest"/></param>
        /// <returns><see cref="DeleteQAResponse"/></returns>
        public DeleteQAResponse DeleteQASync(DeleteQARequest req)
        {
            return InternalRequestAsync<DeleteQAResponse>(req, "DeleteQA")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 分类删除
        /// </summary>
        /// <param name="req"><see cref="DeleteQACateRequest"/></param>
        /// <returns><see cref="DeleteQACateResponse"/></returns>
        public Task<DeleteQACateResponse> DeleteQACate(DeleteQACateRequest req)
        {
            return InternalRequestAsync<DeleteQACateResponse>(req, "DeleteQACate");
        }

        /// <summary>
        /// 分类删除
        /// </summary>
        /// <param name="req"><see cref="DeleteQACateRequest"/></param>
        /// <returns><see cref="DeleteQACateResponse"/></returns>
        public DeleteQACateResponse DeleteQACateSync(DeleteQACateRequest req)
        {
            return InternalRequestAsync<DeleteQACateResponse>(req, "DeleteQACate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除拒答问题
        /// </summary>
        /// <param name="req"><see cref="DeleteRejectedQuestionRequest"/></param>
        /// <returns><see cref="DeleteRejectedQuestionResponse"/></returns>
        public Task<DeleteRejectedQuestionResponse> DeleteRejectedQuestion(DeleteRejectedQuestionRequest req)
        {
            return InternalRequestAsync<DeleteRejectedQuestionResponse>(req, "DeleteRejectedQuestion");
        }

        /// <summary>
        /// 删除拒答问题
        /// </summary>
        /// <param name="req"><see cref="DeleteRejectedQuestionRequest"/></param>
        /// <returns><see cref="DeleteRejectedQuestionResponse"/></returns>
        public DeleteRejectedQuestionResponse DeleteRejectedQuestionSync(DeleteRejectedQuestionRequest req)
        {
            return InternalRequestAsync<DeleteRejectedQuestionResponse>(req, "DeleteRejectedQuestion")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取企业下应用详情
        /// </summary>
        /// <param name="req"><see cref="DescribeAppRequest"/></param>
        /// <returns><see cref="DescribeAppResponse"/></returns>
        public Task<DescribeAppResponse> DescribeApp(DescribeAppRequest req)
        {
            return InternalRequestAsync<DescribeAppResponse>(req, "DescribeApp");
        }

        /// <summary>
        /// 获取企业下应用详情
        /// </summary>
        /// <param name="req"><see cref="DescribeAppRequest"/></param>
        /// <returns><see cref="DescribeAppResponse"/></returns>
        public DescribeAppResponse DescribeAppSync(DescribeAppRequest req)
        {
            return InternalRequestAsync<DescribeAppResponse>(req, "DescribeApp")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询属性标签详情
        /// </summary>
        /// <param name="req"><see cref="DescribeAttributeLabelRequest"/></param>
        /// <returns><see cref="DescribeAttributeLabelResponse"/></returns>
        public Task<DescribeAttributeLabelResponse> DescribeAttributeLabel(DescribeAttributeLabelRequest req)
        {
            return InternalRequestAsync<DescribeAttributeLabelResponse>(req, "DescribeAttributeLabel");
        }

        /// <summary>
        /// 查询属性标签详情
        /// </summary>
        /// <param name="req"><see cref="DescribeAttributeLabelRequest"/></param>
        /// <returns><see cref="DescribeAttributeLabelResponse"/></returns>
        public DescribeAttributeLabelResponse DescribeAttributeLabelSync(DescribeAttributeLabelRequest req)
        {
            return InternalRequestAsync<DescribeAttributeLabelResponse>(req, "DescribeAttributeLabel")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 接口调用折线图
        /// </summary>
        /// <param name="req"><see cref="DescribeCallStatsGraphRequest"/></param>
        /// <returns><see cref="DescribeCallStatsGraphResponse"/></returns>
        public Task<DescribeCallStatsGraphResponse> DescribeCallStatsGraph(DescribeCallStatsGraphRequest req)
        {
            return InternalRequestAsync<DescribeCallStatsGraphResponse>(req, "DescribeCallStatsGraph");
        }

        /// <summary>
        /// 接口调用折线图
        /// </summary>
        /// <param name="req"><see cref="DescribeCallStatsGraphRequest"/></param>
        /// <returns><see cref="DescribeCallStatsGraphResponse"/></returns>
        public DescribeCallStatsGraphResponse DescribeCallStatsGraphSync(DescribeCallStatsGraphRequest req)
        {
            return InternalRequestAsync<DescribeCallStatsGraphResponse>(req, "DescribeCallStatsGraph")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 并发调用响应
        /// </summary>
        /// <param name="req"><see cref="DescribeConcurrencyUsageRequest"/></param>
        /// <returns><see cref="DescribeConcurrencyUsageResponse"/></returns>
        public Task<DescribeConcurrencyUsageResponse> DescribeConcurrencyUsage(DescribeConcurrencyUsageRequest req)
        {
            return InternalRequestAsync<DescribeConcurrencyUsageResponse>(req, "DescribeConcurrencyUsage");
        }

        /// <summary>
        /// 并发调用响应
        /// </summary>
        /// <param name="req"><see cref="DescribeConcurrencyUsageRequest"/></param>
        /// <returns><see cref="DescribeConcurrencyUsageResponse"/></returns>
        public DescribeConcurrencyUsageResponse DescribeConcurrencyUsageSync(DescribeConcurrencyUsageRequest req)
        {
            return InternalRequestAsync<DescribeConcurrencyUsageResponse>(req, "DescribeConcurrencyUsage")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 并发调用折线图
        /// </summary>
        /// <param name="req"><see cref="DescribeConcurrencyUsageGraphRequest"/></param>
        /// <returns><see cref="DescribeConcurrencyUsageGraphResponse"/></returns>
        public Task<DescribeConcurrencyUsageGraphResponse> DescribeConcurrencyUsageGraph(DescribeConcurrencyUsageGraphRequest req)
        {
            return InternalRequestAsync<DescribeConcurrencyUsageGraphResponse>(req, "DescribeConcurrencyUsageGraph");
        }

        /// <summary>
        /// 并发调用折线图
        /// </summary>
        /// <param name="req"><see cref="DescribeConcurrencyUsageGraphRequest"/></param>
        /// <returns><see cref="DescribeConcurrencyUsageGraphResponse"/></returns>
        public DescribeConcurrencyUsageGraphResponse DescribeConcurrencyUsageGraphSync(DescribeConcurrencyUsageGraphRequest req)
        {
            return InternalRequestAsync<DescribeConcurrencyUsageGraphResponse>(req, "DescribeConcurrencyUsageGraph")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 企业详情
        /// </summary>
        /// <param name="req"><see cref="DescribeCorpRequest"/></param>
        /// <returns><see cref="DescribeCorpResponse"/></returns>
        public Task<DescribeCorpResponse> DescribeCorp(DescribeCorpRequest req)
        {
            return InternalRequestAsync<DescribeCorpResponse>(req, "DescribeCorp");
        }

        /// <summary>
        /// 企业详情
        /// </summary>
        /// <param name="req"><see cref="DescribeCorpRequest"/></param>
        /// <returns><see cref="DescribeCorpResponse"/></returns>
        public DescribeCorpResponse DescribeCorpSync(DescribeCorpRequest req)
        {
            return InternalRequestAsync<DescribeCorpResponse>(req, "DescribeCorp")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 文档详情
        /// </summary>
        /// <param name="req"><see cref="DescribeDocRequest"/></param>
        /// <returns><see cref="DescribeDocResponse"/></returns>
        public Task<DescribeDocResponse> DescribeDoc(DescribeDocRequest req)
        {
            return InternalRequestAsync<DescribeDocResponse>(req, "DescribeDoc");
        }

        /// <summary>
        /// 文档详情
        /// </summary>
        /// <param name="req"><see cref="DescribeDocRequest"/></param>
        /// <returns><see cref="DescribeDocResponse"/></returns>
        public DescribeDocResponse DescribeDocSync(DescribeDocRequest req)
        {
            return InternalRequestAsync<DescribeDocResponse>(req, "DescribeDoc")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询知识库用量
        /// </summary>
        /// <param name="req"><see cref="DescribeKnowledgeUsageRequest"/></param>
        /// <returns><see cref="DescribeKnowledgeUsageResponse"/></returns>
        public Task<DescribeKnowledgeUsageResponse> DescribeKnowledgeUsage(DescribeKnowledgeUsageRequest req)
        {
            return InternalRequestAsync<DescribeKnowledgeUsageResponse>(req, "DescribeKnowledgeUsage");
        }

        /// <summary>
        /// 查询知识库用量
        /// </summary>
        /// <param name="req"><see cref="DescribeKnowledgeUsageRequest"/></param>
        /// <returns><see cref="DescribeKnowledgeUsageResponse"/></returns>
        public DescribeKnowledgeUsageResponse DescribeKnowledgeUsageSync(DescribeKnowledgeUsageRequest req)
        {
            return InternalRequestAsync<DescribeKnowledgeUsageResponse>(req, "DescribeKnowledgeUsage")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询企业知识库容量饼图
        /// </summary>
        /// <param name="req"><see cref="DescribeKnowledgeUsagePieGraphRequest"/></param>
        /// <returns><see cref="DescribeKnowledgeUsagePieGraphResponse"/></returns>
        public Task<DescribeKnowledgeUsagePieGraphResponse> DescribeKnowledgeUsagePieGraph(DescribeKnowledgeUsagePieGraphRequest req)
        {
            return InternalRequestAsync<DescribeKnowledgeUsagePieGraphResponse>(req, "DescribeKnowledgeUsagePieGraph");
        }

        /// <summary>
        /// 查询企业知识库容量饼图
        /// </summary>
        /// <param name="req"><see cref="DescribeKnowledgeUsagePieGraphRequest"/></param>
        /// <returns><see cref="DescribeKnowledgeUsagePieGraphResponse"/></returns>
        public DescribeKnowledgeUsagePieGraphResponse DescribeKnowledgeUsagePieGraphSync(DescribeKnowledgeUsagePieGraphRequest req)
        {
            return InternalRequestAsync<DescribeKnowledgeUsagePieGraphResponse>(req, "DescribeKnowledgeUsagePieGraph")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 问答详情
        /// </summary>
        /// <param name="req"><see cref="DescribeQARequest"/></param>
        /// <returns><see cref="DescribeQAResponse"/></returns>
        public Task<DescribeQAResponse> DescribeQA(DescribeQARequest req)
        {
            return InternalRequestAsync<DescribeQAResponse>(req, "DescribeQA");
        }

        /// <summary>
        /// 问答详情
        /// </summary>
        /// <param name="req"><see cref="DescribeQARequest"/></param>
        /// <returns><see cref="DescribeQAResponse"/></returns>
        public DescribeQAResponse DescribeQASync(DescribeQARequest req)
        {
            return InternalRequestAsync<DescribeQAResponse>(req, "DescribeQA")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取来源详情列表
        /// </summary>
        /// <param name="req"><see cref="DescribeReferRequest"/></param>
        /// <returns><see cref="DescribeReferResponse"/></returns>
        public Task<DescribeReferResponse> DescribeRefer(DescribeReferRequest req)
        {
            return InternalRequestAsync<DescribeReferResponse>(req, "DescribeRefer");
        }

        /// <summary>
        /// 获取来源详情列表
        /// </summary>
        /// <param name="req"><see cref="DescribeReferRequest"/></param>
        /// <returns><see cref="DescribeReferResponse"/></returns>
        public DescribeReferResponse DescribeReferSync(DescribeReferRequest req)
        {
            return InternalRequestAsync<DescribeReferResponse>(req, "DescribeRefer")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 发布详情
        /// </summary>
        /// <param name="req"><see cref="DescribeReleaseRequest"/></param>
        /// <returns><see cref="DescribeReleaseResponse"/></returns>
        public Task<DescribeReleaseResponse> DescribeRelease(DescribeReleaseRequest req)
        {
            return InternalRequestAsync<DescribeReleaseResponse>(req, "DescribeRelease");
        }

        /// <summary>
        /// 发布详情
        /// </summary>
        /// <param name="req"><see cref="DescribeReleaseRequest"/></param>
        /// <returns><see cref="DescribeReleaseResponse"/></returns>
        public DescribeReleaseResponse DescribeReleaseSync(DescribeReleaseRequest req)
        {
            return InternalRequestAsync<DescribeReleaseResponse>(req, "DescribeRelease")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 拉取发布按钮状态、最后发布时间
        /// </summary>
        /// <param name="req"><see cref="DescribeReleaseInfoRequest"/></param>
        /// <returns><see cref="DescribeReleaseInfoResponse"/></returns>
        public Task<DescribeReleaseInfoResponse> DescribeReleaseInfo(DescribeReleaseInfoRequest req)
        {
            return InternalRequestAsync<DescribeReleaseInfoResponse>(req, "DescribeReleaseInfo");
        }

        /// <summary>
        /// 拉取发布按钮状态、最后发布时间
        /// </summary>
        /// <param name="req"><see cref="DescribeReleaseInfoRequest"/></param>
        /// <returns><see cref="DescribeReleaseInfoResponse"/></returns>
        public DescribeReleaseInfoResponse DescribeReleaseInfoSync(DescribeReleaseInfoRequest req)
        {
            return InternalRequestAsync<DescribeReleaseInfoResponse>(req, "DescribeReleaseInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 通过appKey获取应用业务ID
        /// </summary>
        /// <param name="req"><see cref="DescribeRobotBizIDByAppKeyRequest"/></param>
        /// <returns><see cref="DescribeRobotBizIDByAppKeyResponse"/></returns>
        public Task<DescribeRobotBizIDByAppKeyResponse> DescribeRobotBizIDByAppKey(DescribeRobotBizIDByAppKeyRequest req)
        {
            return InternalRequestAsync<DescribeRobotBizIDByAppKeyResponse>(req, "DescribeRobotBizIDByAppKey");
        }

        /// <summary>
        /// 通过appKey获取应用业务ID
        /// </summary>
        /// <param name="req"><see cref="DescribeRobotBizIDByAppKeyRequest"/></param>
        /// <returns><see cref="DescribeRobotBizIDByAppKeyResponse"/></returns>
        public DescribeRobotBizIDByAppKeyResponse DescribeRobotBizIDByAppKeySync(DescribeRobotBizIDByAppKeyRequest req)
        {
            return InternalRequestAsync<DescribeRobotBizIDByAppKeyResponse>(req, "DescribeRobotBizIDByAppKey")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询搜索服务调用折线图
        /// </summary>
        /// <param name="req"><see cref="DescribeSearchStatsGraphRequest"/></param>
        /// <returns><see cref="DescribeSearchStatsGraphResponse"/></returns>
        public Task<DescribeSearchStatsGraphResponse> DescribeSearchStatsGraph(DescribeSearchStatsGraphRequest req)
        {
            return InternalRequestAsync<DescribeSearchStatsGraphResponse>(req, "DescribeSearchStatsGraph");
        }

        /// <summary>
        /// 查询搜索服务调用折线图
        /// </summary>
        /// <param name="req"><see cref="DescribeSearchStatsGraphRequest"/></param>
        /// <returns><see cref="DescribeSearchStatsGraphResponse"/></returns>
        public DescribeSearchStatsGraphResponse DescribeSearchStatsGraphSync(DescribeSearchStatsGraphRequest req)
        {
            return InternalRequestAsync<DescribeSearchStatsGraphResponse>(req, "DescribeSearchStatsGraph")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取片段详情
        /// </summary>
        /// <param name="req"><see cref="DescribeSegmentsRequest"/></param>
        /// <returns><see cref="DescribeSegmentsResponse"/></returns>
        public Task<DescribeSegmentsResponse> DescribeSegments(DescribeSegmentsRequest req)
        {
            return InternalRequestAsync<DescribeSegmentsResponse>(req, "DescribeSegments");
        }

        /// <summary>
        /// 获取片段详情
        /// </summary>
        /// <param name="req"><see cref="DescribeSegmentsRequest"/></param>
        /// <returns><see cref="DescribeSegmentsResponse"/></returns>
        public DescribeSegmentsResponse DescribeSegmentsSync(DescribeSegmentsRequest req)
        {
            return InternalRequestAsync<DescribeSegmentsResponse>(req, "DescribeSegments")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取文件上传临时密钥
        /// </summary>
        /// <param name="req"><see cref="DescribeStorageCredentialRequest"/></param>
        /// <returns><see cref="DescribeStorageCredentialResponse"/></returns>
        public Task<DescribeStorageCredentialResponse> DescribeStorageCredential(DescribeStorageCredentialRequest req)
        {
            return InternalRequestAsync<DescribeStorageCredentialResponse>(req, "DescribeStorageCredential");
        }

        /// <summary>
        /// 获取文件上传临时密钥
        /// </summary>
        /// <param name="req"><see cref="DescribeStorageCredentialRequest"/></param>
        /// <returns><see cref="DescribeStorageCredentialResponse"/></returns>
        public DescribeStorageCredentialResponse DescribeStorageCredentialSync(DescribeStorageCredentialRequest req)
        {
            return InternalRequestAsync<DescribeStorageCredentialResponse>(req, "DescribeStorageCredential")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 接口调用token详情
        /// </summary>
        /// <param name="req"><see cref="DescribeTokenUsageRequest"/></param>
        /// <returns><see cref="DescribeTokenUsageResponse"/></returns>
        public Task<DescribeTokenUsageResponse> DescribeTokenUsage(DescribeTokenUsageRequest req)
        {
            return InternalRequestAsync<DescribeTokenUsageResponse>(req, "DescribeTokenUsage");
        }

        /// <summary>
        /// 接口调用token详情
        /// </summary>
        /// <param name="req"><see cref="DescribeTokenUsageRequest"/></param>
        /// <returns><see cref="DescribeTokenUsageResponse"/></returns>
        public DescribeTokenUsageResponse DescribeTokenUsageSync(DescribeTokenUsageRequest req)
        {
            return InternalRequestAsync<DescribeTokenUsageResponse>(req, "DescribeTokenUsage")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 接口调用token折线图
        /// </summary>
        /// <param name="req"><see cref="DescribeTokenUsageGraphRequest"/></param>
        /// <returns><see cref="DescribeTokenUsageGraphResponse"/></returns>
        public Task<DescribeTokenUsageGraphResponse> DescribeTokenUsageGraph(DescribeTokenUsageGraphRequest req)
        {
            return InternalRequestAsync<DescribeTokenUsageGraphResponse>(req, "DescribeTokenUsageGraph");
        }

        /// <summary>
        /// 接口调用token折线图
        /// </summary>
        /// <param name="req"><see cref="DescribeTokenUsageGraphRequest"/></param>
        /// <returns><see cref="DescribeTokenUsageGraphResponse"/></returns>
        public DescribeTokenUsageGraphResponse DescribeTokenUsageGraphSync(DescribeTokenUsageGraphRequest req)
        {
            return InternalRequestAsync<DescribeTokenUsageGraphResponse>(req, "DescribeTokenUsageGraph")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取不满意回复上下文
        /// </summary>
        /// <param name="req"><see cref="DescribeUnsatisfiedReplyContextRequest"/></param>
        /// <returns><see cref="DescribeUnsatisfiedReplyContextResponse"/></returns>
        public Task<DescribeUnsatisfiedReplyContextResponse> DescribeUnsatisfiedReplyContext(DescribeUnsatisfiedReplyContextRequest req)
        {
            return InternalRequestAsync<DescribeUnsatisfiedReplyContextResponse>(req, "DescribeUnsatisfiedReplyContext");
        }

        /// <summary>
        /// 获取不满意回复上下文
        /// </summary>
        /// <param name="req"><see cref="DescribeUnsatisfiedReplyContextRequest"/></param>
        /// <returns><see cref="DescribeUnsatisfiedReplyContextResponse"/></returns>
        public DescribeUnsatisfiedReplyContextResponse DescribeUnsatisfiedReplyContextSync(DescribeUnsatisfiedReplyContextRequest req)
        {
            return InternalRequestAsync<DescribeUnsatisfiedReplyContextResponse>(req, "DescribeUnsatisfiedReplyContext")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 导出属性标签
        /// </summary>
        /// <param name="req"><see cref="ExportAttributeLabelRequest"/></param>
        /// <returns><see cref="ExportAttributeLabelResponse"/></returns>
        public Task<ExportAttributeLabelResponse> ExportAttributeLabel(ExportAttributeLabelRequest req)
        {
            return InternalRequestAsync<ExportAttributeLabelResponse>(req, "ExportAttributeLabel");
        }

        /// <summary>
        /// 导出属性标签
        /// </summary>
        /// <param name="req"><see cref="ExportAttributeLabelRequest"/></param>
        /// <returns><see cref="ExportAttributeLabelResponse"/></returns>
        public ExportAttributeLabelResponse ExportAttributeLabelSync(ExportAttributeLabelRequest req)
        {
            return InternalRequestAsync<ExportAttributeLabelResponse>(req, "ExportAttributeLabel")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 导出QA列表
        /// </summary>
        /// <param name="req"><see cref="ExportQAListRequest"/></param>
        /// <returns><see cref="ExportQAListResponse"/></returns>
        public Task<ExportQAListResponse> ExportQAList(ExportQAListRequest req)
        {
            return InternalRequestAsync<ExportQAListResponse>(req, "ExportQAList");
        }

        /// <summary>
        /// 导出QA列表
        /// </summary>
        /// <param name="req"><see cref="ExportQAListRequest"/></param>
        /// <returns><see cref="ExportQAListResponse"/></returns>
        public ExportQAListResponse ExportQAListSync(ExportQAListRequest req)
        {
            return InternalRequestAsync<ExportQAListResponse>(req, "ExportQAList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 导出不满意回复
        /// </summary>
        /// <param name="req"><see cref="ExportUnsatisfiedReplyRequest"/></param>
        /// <returns><see cref="ExportUnsatisfiedReplyResponse"/></returns>
        public Task<ExportUnsatisfiedReplyResponse> ExportUnsatisfiedReply(ExportUnsatisfiedReplyRequest req)
        {
            return InternalRequestAsync<ExportUnsatisfiedReplyResponse>(req, "ExportUnsatisfiedReply");
        }

        /// <summary>
        /// 导出不满意回复
        /// </summary>
        /// <param name="req"><see cref="ExportUnsatisfiedReplyRequest"/></param>
        /// <returns><see cref="ExportUnsatisfiedReplyResponse"/></returns>
        public ExportUnsatisfiedReplyResponse ExportUnsatisfiedReplySync(ExportUnsatisfiedReplyRequest req)
        {
            return InternalRequestAsync<ExportUnsatisfiedReplyResponse>(req, "ExportUnsatisfiedReply")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 文档生成问答
        /// </summary>
        /// <param name="req"><see cref="GenerateQARequest"/></param>
        /// <returns><see cref="GenerateQAResponse"/></returns>
        public Task<GenerateQAResponse> GenerateQA(GenerateQARequest req)
        {
            return InternalRequestAsync<GenerateQAResponse>(req, "GenerateQA");
        }

        /// <summary>
        /// 文档生成问答
        /// </summary>
        /// <param name="req"><see cref="GenerateQARequest"/></param>
        /// <returns><see cref="GenerateQAResponse"/></returns>
        public GenerateQAResponse GenerateQASync(GenerateQARequest req)
        {
            return InternalRequestAsync<GenerateQAResponse>(req, "GenerateQA")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 回答类型数据统计
        /// </summary>
        /// <param name="req"><see cref="GetAnswerTypeDataCountRequest"/></param>
        /// <returns><see cref="GetAnswerTypeDataCountResponse"/></returns>
        public Task<GetAnswerTypeDataCountResponse> GetAnswerTypeDataCount(GetAnswerTypeDataCountRequest req)
        {
            return InternalRequestAsync<GetAnswerTypeDataCountResponse>(req, "GetAnswerTypeDataCount");
        }

        /// <summary>
        /// 回答类型数据统计
        /// </summary>
        /// <param name="req"><see cref="GetAnswerTypeDataCountRequest"/></param>
        /// <returns><see cref="GetAnswerTypeDataCountResponse"/></returns>
        public GetAnswerTypeDataCountResponse GetAnswerTypeDataCountSync(GetAnswerTypeDataCountRequest req)
        {
            return InternalRequestAsync<GetAnswerTypeDataCountResponse>(req, "GetAnswerTypeDataCount")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取模型列表
        /// </summary>
        /// <param name="req"><see cref="GetAppKnowledgeCountRequest"/></param>
        /// <returns><see cref="GetAppKnowledgeCountResponse"/></returns>
        public Task<GetAppKnowledgeCountResponse> GetAppKnowledgeCount(GetAppKnowledgeCountRequest req)
        {
            return InternalRequestAsync<GetAppKnowledgeCountResponse>(req, "GetAppKnowledgeCount");
        }

        /// <summary>
        /// 获取模型列表
        /// </summary>
        /// <param name="req"><see cref="GetAppKnowledgeCountRequest"/></param>
        /// <returns><see cref="GetAppKnowledgeCountResponse"/></returns>
        public GetAppKnowledgeCountResponse GetAppKnowledgeCountSync(GetAppKnowledgeCountRequest req)
        {
            return InternalRequestAsync<GetAppKnowledgeCountResponse>(req, "GetAppKnowledgeCount")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取应用密钥
        /// </summary>
        /// <param name="req"><see cref="GetAppSecretRequest"/></param>
        /// <returns><see cref="GetAppSecretResponse"/></returns>
        public Task<GetAppSecretResponse> GetAppSecret(GetAppSecretRequest req)
        {
            return InternalRequestAsync<GetAppSecretResponse>(req, "GetAppSecret");
        }

        /// <summary>
        /// 获取应用密钥
        /// </summary>
        /// <param name="req"><see cref="GetAppSecretRequest"/></param>
        /// <returns><see cref="GetAppSecretResponse"/></returns>
        public GetAppSecretResponse GetAppSecretSync(GetAppSecretRequest req)
        {
            return InternalRequestAsync<GetAppSecretResponse>(req, "GetAppSecret")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取文档预览信息
        /// </summary>
        /// <param name="req"><see cref="GetDocPreviewRequest"/></param>
        /// <returns><see cref="GetDocPreviewResponse"/></returns>
        public Task<GetDocPreviewResponse> GetDocPreview(GetDocPreviewRequest req)
        {
            return InternalRequestAsync<GetDocPreviewResponse>(req, "GetDocPreview");
        }

        /// <summary>
        /// 获取文档预览信息
        /// </summary>
        /// <param name="req"><see cref="GetDocPreviewRequest"/></param>
        /// <returns><see cref="GetDocPreviewResponse"/></returns>
        public GetDocPreviewResponse GetDocPreviewSync(GetDocPreviewRequest req)
        {
            return InternalRequestAsync<GetDocPreviewResponse>(req, "GetDocPreview")
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
        /// 点赞点踩数据统计
        /// </summary>
        /// <param name="req"><see cref="GetLikeDataCountRequest"/></param>
        /// <returns><see cref="GetLikeDataCountResponse"/></returns>
        public Task<GetLikeDataCountResponse> GetLikeDataCount(GetLikeDataCountRequest req)
        {
            return InternalRequestAsync<GetLikeDataCountResponse>(req, "GetLikeDataCount");
        }

        /// <summary>
        /// 点赞点踩数据统计
        /// </summary>
        /// <param name="req"><see cref="GetLikeDataCountRequest"/></param>
        /// <returns><see cref="GetLikeDataCountResponse"/></returns>
        public GetLikeDataCountResponse GetLikeDataCountSync(GetLikeDataCountRequest req)
        {
            return InternalRequestAsync<GetLikeDataCountResponse>(req, "GetLikeDataCount")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取聊天历史请求
        /// </summary>
        /// <param name="req"><see cref="GetMsgRecordRequest"/></param>
        /// <returns><see cref="GetMsgRecordResponse"/></returns>
        public Task<GetMsgRecordResponse> GetMsgRecord(GetMsgRecordRequest req)
        {
            return InternalRequestAsync<GetMsgRecordResponse>(req, "GetMsgRecord");
        }

        /// <summary>
        /// 获取聊天历史请求
        /// </summary>
        /// <param name="req"><see cref="GetMsgRecordRequest"/></param>
        /// <returns><see cref="GetMsgRecordResponse"/></returns>
        public GetMsgRecordResponse GetMsgRecordSync(GetMsgRecordRequest req)
        {
            return InternalRequestAsync<GetMsgRecordResponse>(req, "GetMsgRecord")
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
        /// 获取任务状态
        /// </summary>
        /// <param name="req"><see cref="GetTaskStatusRequest"/></param>
        /// <returns><see cref="GetTaskStatusResponse"/></returns>
        public Task<GetTaskStatusResponse> GetTaskStatus(GetTaskStatusRequest req)
        {
            return InternalRequestAsync<GetTaskStatusResponse>(req, "GetTaskStatus");
        }

        /// <summary>
        /// 获取任务状态
        /// </summary>
        /// <param name="req"><see cref="GetTaskStatusRequest"/></param>
        /// <returns><see cref="GetTaskStatusResponse"/></returns>
        public GetTaskStatusResponse GetTaskStatusSync(GetTaskStatusRequest req)
        {
            return InternalRequestAsync<GetTaskStatusResponse>(req, "GetTaskStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询自定义变量列表
        /// </summary>
        /// <param name="req"><see cref="GetVarListRequest"/></param>
        /// <returns><see cref="GetVarListResponse"/></returns>
        public Task<GetVarListResponse> GetVarList(GetVarListRequest req)
        {
            return InternalRequestAsync<GetVarListResponse>(req, "GetVarList");
        }

        /// <summary>
        /// 查询自定义变量列表
        /// </summary>
        /// <param name="req"><see cref="GetVarListRequest"/></param>
        /// <returns><see cref="GetVarListResponse"/></returns>
        public GetVarListResponse GetVarListSync(GetVarListRequest req)
        {
            return InternalRequestAsync<GetVarListResponse>(req, "GetVarList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取ws token
        /// </summary>
        /// <param name="req"><see cref="GetWsTokenRequest"/></param>
        /// <returns><see cref="GetWsTokenResponse"/></returns>
        public Task<GetWsTokenResponse> GetWsToken(GetWsTokenRequest req)
        {
            return InternalRequestAsync<GetWsTokenResponse>(req, "GetWsToken");
        }

        /// <summary>
        /// 获取ws token
        /// </summary>
        /// <param name="req"><see cref="GetWsTokenRequest"/></param>
        /// <returns><see cref="GetWsTokenResponse"/></returns>
        public GetWsTokenResponse GetWsTokenSync(GetWsTokenRequest req)
        {
            return InternalRequestAsync<GetWsTokenResponse>(req, "GetWsToken")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Doc分组
        /// </summary>
        /// <param name="req"><see cref="GroupDocRequest"/></param>
        /// <returns><see cref="GroupDocResponse"/></returns>
        public Task<GroupDocResponse> GroupDoc(GroupDocRequest req)
        {
            return InternalRequestAsync<GroupDocResponse>(req, "GroupDoc");
        }

        /// <summary>
        /// Doc分组
        /// </summary>
        /// <param name="req"><see cref="GroupDocRequest"/></param>
        /// <returns><see cref="GroupDocResponse"/></returns>
        public GroupDocResponse GroupDocSync(GroupDocRequest req)
        {
            return InternalRequestAsync<GroupDocResponse>(req, "GroupDoc")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// QA分组
        /// </summary>
        /// <param name="req"><see cref="GroupQARequest"/></param>
        /// <returns><see cref="GroupQAResponse"/></returns>
        public Task<GroupQAResponse> GroupQA(GroupQARequest req)
        {
            return InternalRequestAsync<GroupQAResponse>(req, "GroupQA");
        }

        /// <summary>
        /// QA分组
        /// </summary>
        /// <param name="req"><see cref="GroupQARequest"/></param>
        /// <returns><see cref="GroupQAResponse"/></returns>
        public GroupQAResponse GroupQASync(GroupQARequest req)
        {
            return InternalRequestAsync<GroupQAResponse>(req, "GroupQA")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 忽略不满意回复
        /// </summary>
        /// <param name="req"><see cref="IgnoreUnsatisfiedReplyRequest"/></param>
        /// <returns><see cref="IgnoreUnsatisfiedReplyResponse"/></returns>
        public Task<IgnoreUnsatisfiedReplyResponse> IgnoreUnsatisfiedReply(IgnoreUnsatisfiedReplyRequest req)
        {
            return InternalRequestAsync<IgnoreUnsatisfiedReplyResponse>(req, "IgnoreUnsatisfiedReply");
        }

        /// <summary>
        /// 忽略不满意回复
        /// </summary>
        /// <param name="req"><see cref="IgnoreUnsatisfiedReplyRequest"/></param>
        /// <returns><see cref="IgnoreUnsatisfiedReplyResponse"/></returns>
        public IgnoreUnsatisfiedReplyResponse IgnoreUnsatisfiedReplySync(IgnoreUnsatisfiedReplyRequest req)
        {
            return InternalRequestAsync<IgnoreUnsatisfiedReplyResponse>(req, "IgnoreUnsatisfiedReply")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 是否意图转人工
        /// </summary>
        /// <param name="req"><see cref="IsTransferIntentRequest"/></param>
        /// <returns><see cref="IsTransferIntentResponse"/></returns>
        public Task<IsTransferIntentResponse> IsTransferIntent(IsTransferIntentRequest req)
        {
            return InternalRequestAsync<IsTransferIntentResponse>(req, "IsTransferIntent");
        }

        /// <summary>
        /// 是否意图转人工
        /// </summary>
        /// <param name="req"><see cref="IsTransferIntentRequest"/></param>
        /// <returns><see cref="IsTransferIntentResponse"/></returns>
        public IsTransferIntentResponse IsTransferIntentSync(IsTransferIntentRequest req)
        {
            return InternalRequestAsync<IsTransferIntentResponse>(req, "IsTransferIntent")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取企业下应用列表
        /// </summary>
        /// <param name="req"><see cref="ListAppRequest"/></param>
        /// <returns><see cref="ListAppResponse"/></returns>
        public Task<ListAppResponse> ListApp(ListAppRequest req)
        {
            return InternalRequestAsync<ListAppResponse>(req, "ListApp");
        }

        /// <summary>
        /// 获取企业下应用列表
        /// </summary>
        /// <param name="req"><see cref="ListAppRequest"/></param>
        /// <returns><see cref="ListAppResponse"/></returns>
        public ListAppResponse ListAppSync(ListAppRequest req)
        {
            return InternalRequestAsync<ListAppResponse>(req, "ListApp")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 应用类型列表
        /// </summary>
        /// <param name="req"><see cref="ListAppCategoryRequest"/></param>
        /// <returns><see cref="ListAppCategoryResponse"/></returns>
        public Task<ListAppCategoryResponse> ListAppCategory(ListAppCategoryRequest req)
        {
            return InternalRequestAsync<ListAppCategoryResponse>(req, "ListAppCategory");
        }

        /// <summary>
        /// 应用类型列表
        /// </summary>
        /// <param name="req"><see cref="ListAppCategoryRequest"/></param>
        /// <returns><see cref="ListAppCategoryResponse"/></returns>
        public ListAppCategoryResponse ListAppCategorySync(ListAppCategoryRequest req)
        {
            return InternalRequestAsync<ListAppCategoryResponse>(req, "ListAppCategory")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 列表查询知识库容量详情
        /// </summary>
        /// <param name="req"><see cref="ListAppKnowledgeDetailRequest"/></param>
        /// <returns><see cref="ListAppKnowledgeDetailResponse"/></returns>
        public Task<ListAppKnowledgeDetailResponse> ListAppKnowledgeDetail(ListAppKnowledgeDetailRequest req)
        {
            return InternalRequestAsync<ListAppKnowledgeDetailResponse>(req, "ListAppKnowledgeDetail");
        }

        /// <summary>
        /// 列表查询知识库容量详情
        /// </summary>
        /// <param name="req"><see cref="ListAppKnowledgeDetailRequest"/></param>
        /// <returns><see cref="ListAppKnowledgeDetailResponse"/></returns>
        public ListAppKnowledgeDetailResponse ListAppKnowledgeDetailSync(ListAppKnowledgeDetailRequest req)
        {
            return InternalRequestAsync<ListAppKnowledgeDetailResponse>(req, "ListAppKnowledgeDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询属性标签列表
        /// </summary>
        /// <param name="req"><see cref="ListAttributeLabelRequest"/></param>
        /// <returns><see cref="ListAttributeLabelResponse"/></returns>
        public Task<ListAttributeLabelResponse> ListAttributeLabel(ListAttributeLabelRequest req)
        {
            return InternalRequestAsync<ListAttributeLabelResponse>(req, "ListAttributeLabel");
        }

        /// <summary>
        /// 查询属性标签列表
        /// </summary>
        /// <param name="req"><see cref="ListAttributeLabelRequest"/></param>
        /// <returns><see cref="ListAttributeLabelResponse"/></returns>
        public ListAttributeLabelResponse ListAttributeLabelSync(ListAttributeLabelRequest req)
        {
            return InternalRequestAsync<ListAttributeLabelResponse>(req, "ListAttributeLabel")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 文档列表
        /// </summary>
        /// <param name="req"><see cref="ListDocRequest"/></param>
        /// <returns><see cref="ListDocResponse"/></returns>
        public Task<ListDocResponse> ListDoc(ListDocRequest req)
        {
            return InternalRequestAsync<ListDocResponse>(req, "ListDoc");
        }

        /// <summary>
        /// 文档列表
        /// </summary>
        /// <param name="req"><see cref="ListDocRequest"/></param>
        /// <returns><see cref="ListDocResponse"/></returns>
        public ListDocResponse ListDocSync(ListDocRequest req)
        {
            return InternalRequestAsync<ListDocResponse>(req, "ListDoc")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取Doc分类
        /// </summary>
        /// <param name="req"><see cref="ListDocCateRequest"/></param>
        /// <returns><see cref="ListDocCateResponse"/></returns>
        public Task<ListDocCateResponse> ListDocCate(ListDocCateRequest req)
        {
            return InternalRequestAsync<ListDocCateResponse>(req, "ListDocCate");
        }

        /// <summary>
        /// 获取Doc分类
        /// </summary>
        /// <param name="req"><see cref="ListDocCateRequest"/></param>
        /// <returns><see cref="ListDocCateResponse"/></returns>
        public ListDocCateResponse ListDocCateSync(ListDocCateRequest req)
        {
            return InternalRequestAsync<ListDocCateResponse>(req, "ListDocCate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取模型列表
        /// </summary>
        /// <param name="req"><see cref="ListModelRequest"/></param>
        /// <returns><see cref="ListModelResponse"/></returns>
        public Task<ListModelResponse> ListModel(ListModelRequest req)
        {
            return InternalRequestAsync<ListModelResponse>(req, "ListModel");
        }

        /// <summary>
        /// 获取模型列表
        /// </summary>
        /// <param name="req"><see cref="ListModelRequest"/></param>
        /// <returns><see cref="ListModelResponse"/></returns>
        public ListModelResponse ListModelSync(ListModelRequest req)
        {
            return InternalRequestAsync<ListModelResponse>(req, "ListModel")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 问答列表
        /// </summary>
        /// <param name="req"><see cref="ListQARequest"/></param>
        /// <returns><see cref="ListQAResponse"/></returns>
        public Task<ListQAResponse> ListQA(ListQARequest req)
        {
            return InternalRequestAsync<ListQAResponse>(req, "ListQA");
        }

        /// <summary>
        /// 问答列表
        /// </summary>
        /// <param name="req"><see cref="ListQARequest"/></param>
        /// <returns><see cref="ListQAResponse"/></returns>
        public ListQAResponse ListQASync(ListQARequest req)
        {
            return InternalRequestAsync<ListQAResponse>(req, "ListQA")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取QA分类
        /// </summary>
        /// <param name="req"><see cref="ListQACateRequest"/></param>
        /// <returns><see cref="ListQACateResponse"/></returns>
        public Task<ListQACateResponse> ListQACate(ListQACateRequest req)
        {
            return InternalRequestAsync<ListQACateResponse>(req, "ListQACate");
        }

        /// <summary>
        /// 获取QA分类
        /// </summary>
        /// <param name="req"><see cref="ListQACateRequest"/></param>
        /// <returns><see cref="ListQACateResponse"/></returns>
        public ListQACateResponse ListQACateSync(ListQACateRequest req)
        {
            return InternalRequestAsync<ListQACateResponse>(req, "ListQACate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取拒答问题
        /// </summary>
        /// <param name="req"><see cref="ListRejectedQuestionRequest"/></param>
        /// <returns><see cref="ListRejectedQuestionResponse"/></returns>
        public Task<ListRejectedQuestionResponse> ListRejectedQuestion(ListRejectedQuestionRequest req)
        {
            return InternalRequestAsync<ListRejectedQuestionResponse>(req, "ListRejectedQuestion");
        }

        /// <summary>
        /// 获取拒答问题
        /// </summary>
        /// <param name="req"><see cref="ListRejectedQuestionRequest"/></param>
        /// <returns><see cref="ListRejectedQuestionResponse"/></returns>
        public ListRejectedQuestionResponse ListRejectedQuestionSync(ListRejectedQuestionRequest req)
        {
            return InternalRequestAsync<ListRejectedQuestionResponse>(req, "ListRejectedQuestion")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 发布拒答问题预览
        /// </summary>
        /// <param name="req"><see cref="ListRejectedQuestionPreviewRequest"/></param>
        /// <returns><see cref="ListRejectedQuestionPreviewResponse"/></returns>
        public Task<ListRejectedQuestionPreviewResponse> ListRejectedQuestionPreview(ListRejectedQuestionPreviewRequest req)
        {
            return InternalRequestAsync<ListRejectedQuestionPreviewResponse>(req, "ListRejectedQuestionPreview");
        }

        /// <summary>
        /// 发布拒答问题预览
        /// </summary>
        /// <param name="req"><see cref="ListRejectedQuestionPreviewRequest"/></param>
        /// <returns><see cref="ListRejectedQuestionPreviewResponse"/></returns>
        public ListRejectedQuestionPreviewResponse ListRejectedQuestionPreviewSync(ListRejectedQuestionPreviewRequest req)
        {
            return InternalRequestAsync<ListRejectedQuestionPreviewResponse>(req, "ListRejectedQuestionPreview")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 发布列表
        /// </summary>
        /// <param name="req"><see cref="ListReleaseRequest"/></param>
        /// <returns><see cref="ListReleaseResponse"/></returns>
        public Task<ListReleaseResponse> ListRelease(ListReleaseRequest req)
        {
            return InternalRequestAsync<ListReleaseResponse>(req, "ListRelease");
        }

        /// <summary>
        /// 发布列表
        /// </summary>
        /// <param name="req"><see cref="ListReleaseRequest"/></param>
        /// <returns><see cref="ListReleaseResponse"/></returns>
        public ListReleaseResponse ListReleaseSync(ListReleaseRequest req)
        {
            return InternalRequestAsync<ListReleaseResponse>(req, "ListRelease")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 发布配置项预览
        /// </summary>
        /// <param name="req"><see cref="ListReleaseConfigPreviewRequest"/></param>
        /// <returns><see cref="ListReleaseConfigPreviewResponse"/></returns>
        public Task<ListReleaseConfigPreviewResponse> ListReleaseConfigPreview(ListReleaseConfigPreviewRequest req)
        {
            return InternalRequestAsync<ListReleaseConfigPreviewResponse>(req, "ListReleaseConfigPreview");
        }

        /// <summary>
        /// 发布配置项预览
        /// </summary>
        /// <param name="req"><see cref="ListReleaseConfigPreviewRequest"/></param>
        /// <returns><see cref="ListReleaseConfigPreviewResponse"/></returns>
        public ListReleaseConfigPreviewResponse ListReleaseConfigPreviewSync(ListReleaseConfigPreviewRequest req)
        {
            return InternalRequestAsync<ListReleaseConfigPreviewResponse>(req, "ListReleaseConfigPreview")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 发布文档预览
        /// </summary>
        /// <param name="req"><see cref="ListReleaseDocPreviewRequest"/></param>
        /// <returns><see cref="ListReleaseDocPreviewResponse"/></returns>
        public Task<ListReleaseDocPreviewResponse> ListReleaseDocPreview(ListReleaseDocPreviewRequest req)
        {
            return InternalRequestAsync<ListReleaseDocPreviewResponse>(req, "ListReleaseDocPreview");
        }

        /// <summary>
        /// 发布文档预览
        /// </summary>
        /// <param name="req"><see cref="ListReleaseDocPreviewRequest"/></param>
        /// <returns><see cref="ListReleaseDocPreviewResponse"/></returns>
        public ListReleaseDocPreviewResponse ListReleaseDocPreviewSync(ListReleaseDocPreviewRequest req)
        {
            return InternalRequestAsync<ListReleaseDocPreviewResponse>(req, "ListReleaseDocPreview")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 文档列表
        /// </summary>
        /// <param name="req"><see cref="ListReleaseQAPreviewRequest"/></param>
        /// <returns><see cref="ListReleaseQAPreviewResponse"/></returns>
        public Task<ListReleaseQAPreviewResponse> ListReleaseQAPreview(ListReleaseQAPreviewRequest req)
        {
            return InternalRequestAsync<ListReleaseQAPreviewResponse>(req, "ListReleaseQAPreview");
        }

        /// <summary>
        /// 文档列表
        /// </summary>
        /// <param name="req"><see cref="ListReleaseQAPreviewRequest"/></param>
        /// <returns><see cref="ListReleaseQAPreviewResponse"/></returns>
        public ListReleaseQAPreviewResponse ListReleaseQAPreviewSync(ListReleaseQAPreviewRequest req)
        {
            return InternalRequestAsync<ListReleaseQAPreviewResponse>(req, "ListReleaseQAPreview")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取账户信息
        /// </summary>
        /// <param name="req"><see cref="ListSelectDocRequest"/></param>
        /// <returns><see cref="ListSelectDocResponse"/></returns>
        public Task<ListSelectDocResponse> ListSelectDoc(ListSelectDocRequest req)
        {
            return InternalRequestAsync<ListSelectDocResponse>(req, "ListSelectDoc");
        }

        /// <summary>
        /// 获取账户信息
        /// </summary>
        /// <param name="req"><see cref="ListSelectDocRequest"/></param>
        /// <returns><see cref="ListSelectDocResponse"/></returns>
        public ListSelectDocResponse ListSelectDocSync(ListSelectDocRequest req)
        {
            return InternalRequestAsync<ListSelectDocResponse>(req, "ListSelectDoc")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询不满意回复列表
        /// </summary>
        /// <param name="req"><see cref="ListUnsatisfiedReplyRequest"/></param>
        /// <returns><see cref="ListUnsatisfiedReplyResponse"/></returns>
        public Task<ListUnsatisfiedReplyResponse> ListUnsatisfiedReply(ListUnsatisfiedReplyRequest req)
        {
            return InternalRequestAsync<ListUnsatisfiedReplyResponse>(req, "ListUnsatisfiedReply");
        }

        /// <summary>
        /// 查询不满意回复列表
        /// </summary>
        /// <param name="req"><see cref="ListUnsatisfiedReplyRequest"/></param>
        /// <returns><see cref="ListUnsatisfiedReplyResponse"/></returns>
        public ListUnsatisfiedReplyResponse ListUnsatisfiedReplySync(ListUnsatisfiedReplyRequest req)
        {
            return InternalRequestAsync<ListUnsatisfiedReplyResponse>(req, "ListUnsatisfiedReply")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 列表查询单次调用明细
        /// </summary>
        /// <param name="req"><see cref="ListUsageCallDetailRequest"/></param>
        /// <returns><see cref="ListUsageCallDetailResponse"/></returns>
        public Task<ListUsageCallDetailResponse> ListUsageCallDetail(ListUsageCallDetailRequest req)
        {
            return InternalRequestAsync<ListUsageCallDetailResponse>(req, "ListUsageCallDetail");
        }

        /// <summary>
        /// 列表查询单次调用明细
        /// </summary>
        /// <param name="req"><see cref="ListUsageCallDetailRequest"/></param>
        /// <returns><see cref="ListUsageCallDetailResponse"/></returns>
        public ListUsageCallDetailResponse ListUsageCallDetailSync(ListUsageCallDetailRequest req)
        {
            return InternalRequestAsync<ListUsageCallDetailResponse>(req, "ListUsageCallDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改应用请求结构体
        /// </summary>
        /// <param name="req"><see cref="ModifyAppRequest"/></param>
        /// <returns><see cref="ModifyAppResponse"/></returns>
        public Task<ModifyAppResponse> ModifyApp(ModifyAppRequest req)
        {
            return InternalRequestAsync<ModifyAppResponse>(req, "ModifyApp");
        }

        /// <summary>
        /// 修改应用请求结构体
        /// </summary>
        /// <param name="req"><see cref="ModifyAppRequest"/></param>
        /// <returns><see cref="ModifyAppResponse"/></returns>
        public ModifyAppResponse ModifyAppSync(ModifyAppRequest req)
        {
            return InternalRequestAsync<ModifyAppResponse>(req, "ModifyApp")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 编辑属性标签
        /// </summary>
        /// <param name="req"><see cref="ModifyAttributeLabelRequest"/></param>
        /// <returns><see cref="ModifyAttributeLabelResponse"/></returns>
        public Task<ModifyAttributeLabelResponse> ModifyAttributeLabel(ModifyAttributeLabelRequest req)
        {
            return InternalRequestAsync<ModifyAttributeLabelResponse>(req, "ModifyAttributeLabel");
        }

        /// <summary>
        /// 编辑属性标签
        /// </summary>
        /// <param name="req"><see cref="ModifyAttributeLabelRequest"/></param>
        /// <returns><see cref="ModifyAttributeLabelResponse"/></returns>
        public ModifyAttributeLabelResponse ModifyAttributeLabelSync(ModifyAttributeLabelRequest req)
        {
            return InternalRequestAsync<ModifyAttributeLabelResponse>(req, "ModifyAttributeLabel")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改文档
        /// </summary>
        /// <param name="req"><see cref="ModifyDocRequest"/></param>
        /// <returns><see cref="ModifyDocResponse"/></returns>
        public Task<ModifyDocResponse> ModifyDoc(ModifyDocRequest req)
        {
            return InternalRequestAsync<ModifyDocResponse>(req, "ModifyDoc");
        }

        /// <summary>
        /// 修改文档
        /// </summary>
        /// <param name="req"><see cref="ModifyDocRequest"/></param>
        /// <returns><see cref="ModifyDocResponse"/></returns>
        public ModifyDocResponse ModifyDocSync(ModifyDocRequest req)
        {
            return InternalRequestAsync<ModifyDocResponse>(req, "ModifyDoc")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 批量修改文档适用范围
        /// </summary>
        /// <param name="req"><see cref="ModifyDocAttrRangeRequest"/></param>
        /// <returns><see cref="ModifyDocAttrRangeResponse"/></returns>
        public Task<ModifyDocAttrRangeResponse> ModifyDocAttrRange(ModifyDocAttrRangeRequest req)
        {
            return InternalRequestAsync<ModifyDocAttrRangeResponse>(req, "ModifyDocAttrRange");
        }

        /// <summary>
        /// 批量修改文档适用范围
        /// </summary>
        /// <param name="req"><see cref="ModifyDocAttrRangeRequest"/></param>
        /// <returns><see cref="ModifyDocAttrRangeResponse"/></returns>
        public ModifyDocAttrRangeResponse ModifyDocAttrRangeSync(ModifyDocAttrRangeRequest req)
        {
            return InternalRequestAsync<ModifyDocAttrRangeResponse>(req, "ModifyDocAttrRange")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改Doc分类
        /// </summary>
        /// <param name="req"><see cref="ModifyDocCateRequest"/></param>
        /// <returns><see cref="ModifyDocCateResponse"/></returns>
        public Task<ModifyDocCateResponse> ModifyDocCate(ModifyDocCateRequest req)
        {
            return InternalRequestAsync<ModifyDocCateResponse>(req, "ModifyDocCate");
        }

        /// <summary>
        /// 修改Doc分类
        /// </summary>
        /// <param name="req"><see cref="ModifyDocCateRequest"/></param>
        /// <returns><see cref="ModifyDocCateResponse"/></returns>
        public ModifyDocCateResponse ModifyDocCateSync(ModifyDocCateRequest req)
        {
            return InternalRequestAsync<ModifyDocCateResponse>(req, "ModifyDocCate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 更新问答
        /// </summary>
        /// <param name="req"><see cref="ModifyQARequest"/></param>
        /// <returns><see cref="ModifyQAResponse"/></returns>
        public Task<ModifyQAResponse> ModifyQA(ModifyQARequest req)
        {
            return InternalRequestAsync<ModifyQAResponse>(req, "ModifyQA");
        }

        /// <summary>
        /// 更新问答
        /// </summary>
        /// <param name="req"><see cref="ModifyQARequest"/></param>
        /// <returns><see cref="ModifyQAResponse"/></returns>
        public ModifyQAResponse ModifyQASync(ModifyQARequest req)
        {
            return InternalRequestAsync<ModifyQAResponse>(req, "ModifyQA")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 批量修改问答适用范围
        /// </summary>
        /// <param name="req"><see cref="ModifyQAAttrRangeRequest"/></param>
        /// <returns><see cref="ModifyQAAttrRangeResponse"/></returns>
        public Task<ModifyQAAttrRangeResponse> ModifyQAAttrRange(ModifyQAAttrRangeRequest req)
        {
            return InternalRequestAsync<ModifyQAAttrRangeResponse>(req, "ModifyQAAttrRange");
        }

        /// <summary>
        /// 批量修改问答适用范围
        /// </summary>
        /// <param name="req"><see cref="ModifyQAAttrRangeRequest"/></param>
        /// <returns><see cref="ModifyQAAttrRangeResponse"/></returns>
        public ModifyQAAttrRangeResponse ModifyQAAttrRangeSync(ModifyQAAttrRangeRequest req)
        {
            return InternalRequestAsync<ModifyQAAttrRangeResponse>(req, "ModifyQAAttrRange")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 更新QA分类
        /// </summary>
        /// <param name="req"><see cref="ModifyQACateRequest"/></param>
        /// <returns><see cref="ModifyQACateResponse"/></returns>
        public Task<ModifyQACateResponse> ModifyQACate(ModifyQACateRequest req)
        {
            return InternalRequestAsync<ModifyQACateResponse>(req, "ModifyQACate");
        }

        /// <summary>
        /// 更新QA分类
        /// </summary>
        /// <param name="req"><see cref="ModifyQACateRequest"/></param>
        /// <returns><see cref="ModifyQACateResponse"/></returns>
        public ModifyQACateResponse ModifyQACateSync(ModifyQACateRequest req)
        {
            return InternalRequestAsync<ModifyQACateResponse>(req, "ModifyQACate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改拒答问题
        /// </summary>
        /// <param name="req"><see cref="ModifyRejectedQuestionRequest"/></param>
        /// <returns><see cref="ModifyRejectedQuestionResponse"/></returns>
        public Task<ModifyRejectedQuestionResponse> ModifyRejectedQuestion(ModifyRejectedQuestionRequest req)
        {
            return InternalRequestAsync<ModifyRejectedQuestionResponse>(req, "ModifyRejectedQuestion");
        }

        /// <summary>
        /// 修改拒答问题
        /// </summary>
        /// <param name="req"><see cref="ModifyRejectedQuestionRequest"/></param>
        /// <returns><see cref="ModifyRejectedQuestionResponse"/></returns>
        public ModifyRejectedQuestionResponse ModifyRejectedQuestionSync(ModifyRejectedQuestionRequest req)
        {
            return InternalRequestAsync<ModifyRejectedQuestionResponse>(req, "ModifyRejectedQuestion")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 多轮改写（QueryRewrite）主要用于多轮对话中，进行指代消解和省略补全。使用本接口，无需输入prompt描述，根据对话历史即可生成更精确的用户查询。在应用场景上，本接口可应用于智能问答、对话式搜索等多种场景。
        /// 本接口（QueryRewrite）有单账号调用上限控制，如您有提高并发限制的需求请 [联系我们](https://cloud.tencent.com/act/event/Online_service) 。
        /// </summary>
        /// <param name="req"><see cref="QueryRewriteRequest"/></param>
        /// <returns><see cref="QueryRewriteResponse"/></returns>
        public Task<QueryRewriteResponse> QueryRewrite(QueryRewriteRequest req)
        {
            return InternalRequestAsync<QueryRewriteResponse>(req, "QueryRewrite");
        }

        /// <summary>
        /// 多轮改写（QueryRewrite）主要用于多轮对话中，进行指代消解和省略补全。使用本接口，无需输入prompt描述，根据对话历史即可生成更精确的用户查询。在应用场景上，本接口可应用于智能问答、对话式搜索等多种场景。
        /// 本接口（QueryRewrite）有单账号调用上限控制，如您有提高并发限制的需求请 [联系我们](https://cloud.tencent.com/act/event/Online_service) 。
        /// </summary>
        /// <param name="req"><see cref="QueryRewriteRequest"/></param>
        /// <returns><see cref="QueryRewriteResponse"/></returns>
        public QueryRewriteResponse QueryRewriteSync(QueryRewriteRequest req)
        {
            return InternalRequestAsync<QueryRewriteResponse>(req, "QueryRewrite")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 点赞点踩消息
        /// </summary>
        /// <param name="req"><see cref="RateMsgRecordRequest"/></param>
        /// <returns><see cref="RateMsgRecordResponse"/></returns>
        public Task<RateMsgRecordResponse> RateMsgRecord(RateMsgRecordRequest req)
        {
            return InternalRequestAsync<RateMsgRecordResponse>(req, "RateMsgRecord");
        }

        /// <summary>
        /// 点赞点踩消息
        /// </summary>
        /// <param name="req"><see cref="RateMsgRecordRequest"/></param>
        /// <returns><see cref="RateMsgRecordResponse"/></returns>
        public RateMsgRecordResponse RateMsgRecordSync(RateMsgRecordRequest req)
        {
            return InternalRequestAsync<RateMsgRecordResponse>(req, "RateMsgRecord")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 支持将图片或PDF文件转换成Markdown格式文件，可解析包括表格、公式、图片、标题、段落、页眉、页脚等内容元素，并将内容智能转换成阅读顺序。
        /// 
        /// 体验期间单账号限制qps仅为1，若有正式接入需要请与产研团队沟通开放。
        /// </summary>
        /// <param name="req"><see cref="ReconstructDocumentRequest"/></param>
        /// <returns><see cref="ReconstructDocumentResponse"/></returns>
        public Task<ReconstructDocumentResponse> ReconstructDocument(ReconstructDocumentRequest req)
        {
            return InternalRequestAsync<ReconstructDocumentResponse>(req, "ReconstructDocument");
        }

        /// <summary>
        /// 支持将图片或PDF文件转换成Markdown格式文件，可解析包括表格、公式、图片、标题、段落、页眉、页脚等内容元素，并将内容智能转换成阅读顺序。
        /// 
        /// 体验期间单账号限制qps仅为1，若有正式接入需要请与产研团队沟通开放。
        /// </summary>
        /// <param name="req"><see cref="ReconstructDocumentRequest"/></param>
        /// <returns><see cref="ReconstructDocumentResponse"/></returns>
        public ReconstructDocumentResponse ReconstructDocumentSync(ReconstructDocumentRequest req)
        {
            return InternalRequestAsync<ReconstructDocumentResponse>(req, "ReconstructDocument")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 文档重命名
        /// </summary>
        /// <param name="req"><see cref="RenameDocRequest"/></param>
        /// <returns><see cref="RenameDocResponse"/></returns>
        public Task<RenameDocResponse> RenameDoc(RenameDocRequest req)
        {
            return InternalRequestAsync<RenameDocResponse>(req, "RenameDoc");
        }

        /// <summary>
        /// 文档重命名
        /// </summary>
        /// <param name="req"><see cref="RenameDocRequest"/></param>
        /// <returns><see cref="RenameDocResponse"/></returns>
        public RenameDocResponse RenameDocSync(RenameDocRequest req)
        {
            return InternalRequestAsync<RenameDocResponse>(req, "RenameDoc")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 文档解析重试
        /// </summary>
        /// <param name="req"><see cref="RetryDocAuditRequest"/></param>
        /// <returns><see cref="RetryDocAuditResponse"/></returns>
        public Task<RetryDocAuditResponse> RetryDocAudit(RetryDocAuditRequest req)
        {
            return InternalRequestAsync<RetryDocAuditResponse>(req, "RetryDocAudit");
        }

        /// <summary>
        /// 文档解析重试
        /// </summary>
        /// <param name="req"><see cref="RetryDocAuditRequest"/></param>
        /// <returns><see cref="RetryDocAuditResponse"/></returns>
        public RetryDocAuditResponse RetryDocAuditSync(RetryDocAuditRequest req)
        {
            return InternalRequestAsync<RetryDocAuditResponse>(req, "RetryDocAudit")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 文档解析重试
        /// </summary>
        /// <param name="req"><see cref="RetryDocParseRequest"/></param>
        /// <returns><see cref="RetryDocParseResponse"/></returns>
        public Task<RetryDocParseResponse> RetryDocParse(RetryDocParseRequest req)
        {
            return InternalRequestAsync<RetryDocParseResponse>(req, "RetryDocParse");
        }

        /// <summary>
        /// 文档解析重试
        /// </summary>
        /// <param name="req"><see cref="RetryDocParseRequest"/></param>
        /// <returns><see cref="RetryDocParseResponse"/></returns>
        public RetryDocParseResponse RetryDocParseSync(RetryDocParseRequest req)
        {
            return InternalRequestAsync<RetryDocParseResponse>(req, "RetryDocParse")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 发布暂停后重试
        /// </summary>
        /// <param name="req"><see cref="RetryReleaseRequest"/></param>
        /// <returns><see cref="RetryReleaseResponse"/></returns>
        public Task<RetryReleaseResponse> RetryRelease(RetryReleaseRequest req)
        {
            return InternalRequestAsync<RetryReleaseResponse>(req, "RetryRelease");
        }

        /// <summary>
        /// 发布暂停后重试
        /// </summary>
        /// <param name="req"><see cref="RetryReleaseRequest"/></param>
        /// <returns><see cref="RetryReleaseResponse"/></returns>
        public RetryReleaseResponse RetryReleaseSync(RetryReleaseRequest req)
        {
            return InternalRequestAsync<RetryReleaseResponse>(req, "RetryRelease")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 基于知识引擎精调模型技术的rerank模型，支持对多路召回的结果进行重排序，根据query与切片内容的相关性，按分数由高到低对切片进行排序，并输出对应的打分结果。（这个接口已下线，请使用新接口，接口文档：https://cloud.tencent.com/document/product/1772/115339）。
        /// </summary>
        /// <param name="req"><see cref="RunReRankRequest"/></param>
        /// <returns><see cref="RunReRankResponse"/></returns>
        public Task<RunReRankResponse> RunReRank(RunReRankRequest req)
        {
            return InternalRequestAsync<RunReRankResponse>(req, "RunReRank");
        }

        /// <summary>
        /// 基于知识引擎精调模型技术的rerank模型，支持对多路召回的结果进行重排序，根据query与切片内容的相关性，按分数由高到低对切片进行排序，并输出对应的打分结果。（这个接口已下线，请使用新接口，接口文档：https://cloud.tencent.com/document/product/1772/115339）。
        /// </summary>
        /// <param name="req"><see cref="RunReRankRequest"/></param>
        /// <returns><see cref="RunReRankResponse"/></returns>
        public RunReRankResponse RunReRankSync(RunReRankRequest req)
        {
            return InternalRequestAsync<RunReRankResponse>(req, "RunReRank")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 知识库文档问答保存。
        /// 将文件存储到应用的知识库内需要三步：
        /// 1.获取临时密钥，参考[接口文档](https://cloud.tencent.com/document/product/1759/105050)。获取临时密钥不同参数组合权限不一样，可参考 [知识引擎操作 cos 指南](https://cloud.tencent.com/document/product/1759/116238)
        /// 2.调用腾讯云提供的 cos 存储接口，将文件存储到知识引擎 cos 中：具体可参考[ COS SDK 概览](https://cloud.tencent.com/document/product/436/6474), 注意使用的是临时密钥的方式操作 COS 
        /// 3.调用本接口，将文件的基础信息存储到知识引擎中。
        /// 以上步骤可参考[文档](https://cloud.tencent.com/document/product/1759/108903)，文档最后有[代码demo](https://cloud.tencent.com/document/product/1759/108903#demo)，可作为参考。
        /// </summary>
        /// <param name="req"><see cref="SaveDocRequest"/></param>
        /// <returns><see cref="SaveDocResponse"/></returns>
        public Task<SaveDocResponse> SaveDoc(SaveDocRequest req)
        {
            return InternalRequestAsync<SaveDocResponse>(req, "SaveDoc");
        }

        /// <summary>
        /// 知识库文档问答保存。
        /// 将文件存储到应用的知识库内需要三步：
        /// 1.获取临时密钥，参考[接口文档](https://cloud.tencent.com/document/product/1759/105050)。获取临时密钥不同参数组合权限不一样，可参考 [知识引擎操作 cos 指南](https://cloud.tencent.com/document/product/1759/116238)
        /// 2.调用腾讯云提供的 cos 存储接口，将文件存储到知识引擎 cos 中：具体可参考[ COS SDK 概览](https://cloud.tencent.com/document/product/436/6474), 注意使用的是临时密钥的方式操作 COS 
        /// 3.调用本接口，将文件的基础信息存储到知识引擎中。
        /// 以上步骤可参考[文档](https://cloud.tencent.com/document/product/1759/108903)，文档最后有[代码demo](https://cloud.tencent.com/document/product/1759/108903#demo)，可作为参考。
        /// </summary>
        /// <param name="req"><see cref="SaveDocRequest"/></param>
        /// <returns><see cref="SaveDocResponse"/></returns>
        public SaveDocResponse SaveDocSync(SaveDocRequest req)
        {
            return InternalRequestAsync<SaveDocResponse>(req, "SaveDoc")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 终止文档解析
        /// </summary>
        /// <param name="req"><see cref="StopDocParseRequest"/></param>
        /// <returns><see cref="StopDocParseResponse"/></returns>
        public Task<StopDocParseResponse> StopDocParse(StopDocParseRequest req)
        {
            return InternalRequestAsync<StopDocParseResponse>(req, "StopDocParse");
        }

        /// <summary>
        /// 终止文档解析
        /// </summary>
        /// <param name="req"><see cref="StopDocParseRequest"/></param>
        /// <returns><see cref="StopDocParseResponse"/></returns>
        public StopDocParseResponse StopDocParseSync(StopDocParseRequest req)
        {
            return InternalRequestAsync<StopDocParseResponse>(req, "StopDocParse")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 上传导入属性标签
        /// </summary>
        /// <param name="req"><see cref="UploadAttributeLabelRequest"/></param>
        /// <returns><see cref="UploadAttributeLabelResponse"/></returns>
        public Task<UploadAttributeLabelResponse> UploadAttributeLabel(UploadAttributeLabelRequest req)
        {
            return InternalRequestAsync<UploadAttributeLabelResponse>(req, "UploadAttributeLabel");
        }

        /// <summary>
        /// 上传导入属性标签
        /// </summary>
        /// <param name="req"><see cref="UploadAttributeLabelRequest"/></param>
        /// <returns><see cref="UploadAttributeLabelResponse"/></returns>
        public UploadAttributeLabelResponse UploadAttributeLabelSync(UploadAttributeLabelRequest req)
        {
            return InternalRequestAsync<UploadAttributeLabelResponse>(req, "UploadAttributeLabel")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 校验问答
        /// </summary>
        /// <param name="req"><see cref="VerifyQARequest"/></param>
        /// <returns><see cref="VerifyQAResponse"/></returns>
        public Task<VerifyQAResponse> VerifyQA(VerifyQARequest req)
        {
            return InternalRequestAsync<VerifyQAResponse>(req, "VerifyQA");
        }

        /// <summary>
        /// 校验问答
        /// </summary>
        /// <param name="req"><see cref="VerifyQARequest"/></param>
        /// <returns><see cref="VerifyQAResponse"/></returns>
        public VerifyQAResponse VerifyQASync(VerifyQARequest req)
        {
            return InternalRequestAsync<VerifyQAResponse>(req, "VerifyQA")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
