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

namespace TencentCloud.Nlp.V20190408
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Nlp.V20190408.Models;

   public class NlpClient : AbstractClient{

       private const string endpoint = "nlp.tencentcloudapi.com";
       private const string version = "2019-04-08";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public NlpClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public NlpClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 利用人工智能算法，自动抽取文本中的关键信息并生成指定长度的文本摘要。可用于新闻标题生成、科技文献摘要生成和商品评论摘要等。
        /// </summary>
        /// <param name="req"><see cref="AutoSummarizationRequest"/></param>
        /// <returns><see cref="AutoSummarizationResponse"/></returns>
        public async Task<AutoSummarizationResponse> AutoSummarization(AutoSummarizationRequest req)
        {
             JsonResponseModel<AutoSummarizationResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AutoSummarization");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AutoSummarizationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 利用人工智能算法，自动抽取文本中的关键信息并生成指定长度的文本摘要。可用于新闻标题生成、科技文献摘要生成和商品评论摘要等。
        /// </summary>
        /// <param name="req"><see cref="AutoSummarizationRequest"/></param>
        /// <returns><see cref="AutoSummarizationResponse"/></returns>
        public AutoSummarizationResponse AutoSummarizationSync(AutoSummarizationRequest req)
        {
             JsonResponseModel<AutoSummarizationResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AutoSummarization");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AutoSummarizationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 闲聊服务基于腾讯领先的NLP引擎能力、数据运算能力和千亿级互联网语料数据的支持，同时集成了广泛的知识问答能力，可实现上百种自定义属性配置，以及儿童语言风格及说话方式，从而让聊天变得更睿智、简单和有趣。
        /// 
        /// </summary>
        /// <param name="req"><see cref="ChatBotRequest"/></param>
        /// <returns><see cref="ChatBotResponse"/></returns>
        public async Task<ChatBotResponse> ChatBot(ChatBotRequest req)
        {
             JsonResponseModel<ChatBotResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ChatBot");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ChatBotResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 闲聊服务基于腾讯领先的NLP引擎能力、数据运算能力和千亿级互联网语料数据的支持，同时集成了广泛的知识问答能力，可实现上百种自定义属性配置，以及儿童语言风格及说话方式，从而让聊天变得更睿智、简单和有趣。
        /// 
        /// </summary>
        /// <param name="req"><see cref="ChatBotRequest"/></param>
        /// <returns><see cref="ChatBotResponse"/></returns>
        public ChatBotResponse ChatBotSync(ChatBotRequest req)
        {
             JsonResponseModel<ChatBotResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ChatBot");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ChatBotResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 根据指定的名称、描述创建自定义词库。
        /// </summary>
        /// <param name="req"><see cref="CreateDictRequest"/></param>
        /// <returns><see cref="CreateDictResponse"/></returns>
        public async Task<CreateDictResponse> CreateDict(CreateDictRequest req)
        {
             JsonResponseModel<CreateDictResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateDict");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDictResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 根据指定的名称、描述创建自定义词库。
        /// </summary>
        /// <param name="req"><see cref="CreateDictRequest"/></param>
        /// <returns><see cref="CreateDictResponse"/></returns>
        public CreateDictResponse CreateDictSync(CreateDictRequest req)
        {
             JsonResponseModel<CreateDictResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateDict");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDictResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 向指定的词库中添加词条。
        /// </summary>
        /// <param name="req"><see cref="CreateWordItemsRequest"/></param>
        /// <returns><see cref="CreateWordItemsResponse"/></returns>
        public async Task<CreateWordItemsResponse> CreateWordItems(CreateWordItemsRequest req)
        {
             JsonResponseModel<CreateWordItemsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateWordItems");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateWordItemsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 向指定的词库中添加词条。
        /// </summary>
        /// <param name="req"><see cref="CreateWordItemsRequest"/></param>
        /// <returns><see cref="CreateWordItemsResponse"/></returns>
        public CreateWordItemsResponse CreateWordItemsSync(CreateWordItemsRequest req)
        {
             JsonResponseModel<CreateWordItemsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateWordItems");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateWordItemsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除自定义词库，会附带相应删除词库包含的所有词条。
        /// </summary>
        /// <param name="req"><see cref="DeleteDictRequest"/></param>
        /// <returns><see cref="DeleteDictResponse"/></returns>
        public async Task<DeleteDictResponse> DeleteDict(DeleteDictRequest req)
        {
             JsonResponseModel<DeleteDictResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteDict");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteDictResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除自定义词库，会附带相应删除词库包含的所有词条。
        /// </summary>
        /// <param name="req"><see cref="DeleteDictRequest"/></param>
        /// <returns><see cref="DeleteDictResponse"/></returns>
        public DeleteDictResponse DeleteDictSync(DeleteDictRequest req)
        {
             JsonResponseModel<DeleteDictResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteDict");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteDictResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于删除自定义词库中的词条。
        /// </summary>
        /// <param name="req"><see cref="DeleteWordItemsRequest"/></param>
        /// <returns><see cref="DeleteWordItemsResponse"/></returns>
        public async Task<DeleteWordItemsResponse> DeleteWordItems(DeleteWordItemsRequest req)
        {
             JsonResponseModel<DeleteWordItemsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteWordItems");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteWordItemsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于删除自定义词库中的词条。
        /// </summary>
        /// <param name="req"><see cref="DeleteWordItemsRequest"/></param>
        /// <returns><see cref="DeleteWordItemsResponse"/></returns>
        public DeleteWordItemsResponse DeleteWordItemsSync(DeleteWordItemsRequest req)
        {
             JsonResponseModel<DeleteWordItemsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteWordItems");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteWordItemsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 句法依存分析接口能够分析出句子中词与词之间的相互依存关系，并揭示其句法结构，包括主谓关系、动宾关系、核心关系等等，可用于提取句子主干、提取句子核心词等，在机器翻译、自动问答、知识抽取等领域都有很好的应用。
        /// </summary>
        /// <param name="req"><see cref="DependencyParsingRequest"/></param>
        /// <returns><see cref="DependencyParsingResponse"/></returns>
        public async Task<DependencyParsingResponse> DependencyParsing(DependencyParsingRequest req)
        {
             JsonResponseModel<DependencyParsingResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DependencyParsing");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DependencyParsingResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 句法依存分析接口能够分析出句子中词与词之间的相互依存关系，并揭示其句法结构，包括主谓关系、动宾关系、核心关系等等，可用于提取句子主干、提取句子核心词等，在机器翻译、自动问答、知识抽取等领域都有很好的应用。
        /// </summary>
        /// <param name="req"><see cref="DependencyParsingRequest"/></param>
        /// <returns><see cref="DependencyParsingResponse"/></returns>
        public DependencyParsingResponse DependencyParsingSync(DependencyParsingRequest req)
        {
             JsonResponseModel<DependencyParsingResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DependencyParsing");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DependencyParsingResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 根据id或名称查询自定义词库信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeDictRequest"/></param>
        /// <returns><see cref="DescribeDictResponse"/></returns>
        public async Task<DescribeDictResponse> DescribeDict(DescribeDictRequest req)
        {
             JsonResponseModel<DescribeDictResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDict");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDictResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 根据id或名称查询自定义词库信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeDictRequest"/></param>
        /// <returns><see cref="DescribeDictResponse"/></returns>
        public DescribeDictResponse DescribeDictSync(DescribeDictRequest req)
        {
             JsonResponseModel<DescribeDictResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDict");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDictResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 返回属于当前用户的所有自定义词库列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeDictsRequest"/></param>
        /// <returns><see cref="DescribeDictsResponse"/></returns>
        public async Task<DescribeDictsResponse> DescribeDicts(DescribeDictsRequest req)
        {
             JsonResponseModel<DescribeDictsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDicts");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDictsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 返回属于当前用户的所有自定义词库列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeDictsRequest"/></param>
        /// <returns><see cref="DescribeDictsResponse"/></returns>
        public DescribeDictsResponse DescribeDictsSync(DescribeDictsRequest req)
        {
             JsonResponseModel<DescribeDictsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDicts");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDictsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 输入实体名称，返回实体相关的信息如实体别名、实体英文名、实体详细信息、相关实体等。
        /// </summary>
        /// <param name="req"><see cref="DescribeEntityRequest"/></param>
        /// <returns><see cref="DescribeEntityResponse"/></returns>
        public async Task<DescribeEntityResponse> DescribeEntity(DescribeEntityRequest req)
        {
             JsonResponseModel<DescribeEntityResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeEntity");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeEntityResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 输入实体名称，返回实体相关的信息如实体别名、实体英文名、实体详细信息、相关实体等。
        /// </summary>
        /// <param name="req"><see cref="DescribeEntityRequest"/></param>
        /// <returns><see cref="DescribeEntityResponse"/></returns>
        public DescribeEntityResponse DescribeEntitySync(DescribeEntityRequest req)
        {
             JsonResponseModel<DescribeEntityResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeEntity");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeEntityResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 输入两个实体，返回两个实体间的关系，例如马化腾与腾讯公司不仅是相关实体，二者还存在隶属关系（马化腾属于腾讯公司）。
        /// </summary>
        /// <param name="req"><see cref="DescribeRelationRequest"/></param>
        /// <returns><see cref="DescribeRelationResponse"/></returns>
        public async Task<DescribeRelationResponse> DescribeRelation(DescribeRelationRequest req)
        {
             JsonResponseModel<DescribeRelationResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeRelation");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRelationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 输入两个实体，返回两个实体间的关系，例如马化腾与腾讯公司不仅是相关实体，二者还存在隶属关系（马化腾属于腾讯公司）。
        /// </summary>
        /// <param name="req"><see cref="DescribeRelationRequest"/></param>
        /// <returns><see cref="DescribeRelationResponse"/></returns>
        public DescribeRelationResponse DescribeRelationSync(DescribeRelationRequest req)
        {
             JsonResponseModel<DescribeRelationResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeRelation");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRelationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 三元组查询，主要分为两类，SP查询和PO查询。SP查询表示已知主语和谓语查询宾语，PO查询表示已知宾语和谓语查询主语。每一个SP或PO查询都是一个可独立执行的查询，TQL支持SP查询的嵌套查询，即主语可以是一个嵌套的子查询。其他复杂的三元组查询方法，请参考官网API文档示例。
        /// </summary>
        /// <param name="req"><see cref="DescribeTripleRequest"/></param>
        /// <returns><see cref="DescribeTripleResponse"/></returns>
        public async Task<DescribeTripleResponse> DescribeTriple(DescribeTripleRequest req)
        {
             JsonResponseModel<DescribeTripleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTriple");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTripleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 三元组查询，主要分为两类，SP查询和PO查询。SP查询表示已知主语和谓语查询宾语，PO查询表示已知宾语和谓语查询主语。每一个SP或PO查询都是一个可独立执行的查询，TQL支持SP查询的嵌套查询，即主语可以是一个嵌套的子查询。其他复杂的三元组查询方法，请参考官网API文档示例。
        /// </summary>
        /// <param name="req"><see cref="DescribeTripleRequest"/></param>
        /// <returns><see cref="DescribeTripleResponse"/></returns>
        public DescribeTripleResponse DescribeTripleSync(DescribeTripleRequest req)
        {
             JsonResponseModel<DescribeTripleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTriple");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTripleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 依据自定义词库的ID，查询对应的词条信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeWordItemsRequest"/></param>
        /// <returns><see cref="DescribeWordItemsResponse"/></returns>
        public async Task<DescribeWordItemsResponse> DescribeWordItems(DescribeWordItemsRequest req)
        {
             JsonResponseModel<DescribeWordItemsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeWordItems");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeWordItemsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 依据自定义词库的ID，查询对应的词条信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeWordItemsRequest"/></param>
        /// <returns><see cref="DescribeWordItemsResponse"/></returns>
        public DescribeWordItemsResponse DescribeWordItemsSync(DescribeWordItemsRequest req)
        {
             JsonResponseModel<DescribeWordItemsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeWordItems");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeWordItemsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 基于关键词提取平台，通过对文本内容进行深度分析，提取出文本内容中的关键信息，为用户实现诸如新闻内容关键词自动提取、评论关键词提取等提供基础服务。
        /// </summary>
        /// <param name="req"><see cref="KeywordsExtractionRequest"/></param>
        /// <returns><see cref="KeywordsExtractionResponse"/></returns>
        public async Task<KeywordsExtractionResponse> KeywordsExtraction(KeywordsExtractionRequest req)
        {
             JsonResponseModel<KeywordsExtractionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "KeywordsExtraction");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<KeywordsExtractionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 基于关键词提取平台，通过对文本内容进行深度分析，提取出文本内容中的关键信息，为用户实现诸如新闻内容关键词自动提取、评论关键词提取等提供基础服务。
        /// </summary>
        /// <param name="req"><see cref="KeywordsExtractionRequest"/></param>
        /// <returns><see cref="KeywordsExtractionResponse"/></returns>
        public KeywordsExtractionResponse KeywordsExtractionSync(KeywordsExtractionRequest req)
        {
             JsonResponseModel<KeywordsExtractionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "KeywordsExtraction");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<KeywordsExtractionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 词法分析接口提供以下三个功能：
        /// 
        /// 1、智能分词：将连续的自然语言文本，切分成具有语义合理性和完整性的词汇序列；
        /// 
        /// 2、词性标注：为每一个词附上对应的词性，例如名词、代词、形容词、动词等；
        /// 
        /// 3、命名实体识别：快速识别文本中的实体，例如人名、地名、机构名等。
        /// 
        /// 所有的功能均基于千亿级大规模互联网语料进行持续迭代更新，以保证效果不断提升，用户无需担心新词发现、歧义消除、调用性能等问题。目前词法分析已经在泛互联网、金融、政务等不同垂直领域提供业务支持，并取得良好的效果。
        /// </summary>
        /// <param name="req"><see cref="LexicalAnalysisRequest"/></param>
        /// <returns><see cref="LexicalAnalysisResponse"/></returns>
        public async Task<LexicalAnalysisResponse> LexicalAnalysis(LexicalAnalysisRequest req)
        {
             JsonResponseModel<LexicalAnalysisResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "LexicalAnalysis");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<LexicalAnalysisResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 词法分析接口提供以下三个功能：
        /// 
        /// 1、智能分词：将连续的自然语言文本，切分成具有语义合理性和完整性的词汇序列；
        /// 
        /// 2、词性标注：为每一个词附上对应的词性，例如名词、代词、形容词、动词等；
        /// 
        /// 3、命名实体识别：快速识别文本中的实体，例如人名、地名、机构名等。
        /// 
        /// 所有的功能均基于千亿级大规模互联网语料进行持续迭代更新，以保证效果不断提升，用户无需担心新词发现、歧义消除、调用性能等问题。目前词法分析已经在泛互联网、金融、政务等不同垂直领域提供业务支持，并取得良好的效果。
        /// </summary>
        /// <param name="req"><see cref="LexicalAnalysisRequest"/></param>
        /// <returns><see cref="LexicalAnalysisResponse"/></returns>
        public LexicalAnalysisResponse LexicalAnalysisSync(LexicalAnalysisRequest req)
        {
             JsonResponseModel<LexicalAnalysisResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "LexicalAnalysis");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<LexicalAnalysisResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询指定自定义词库中的词条是否存在。
        /// </summary>
        /// <param name="req"><see cref="SearchWordItemsRequest"/></param>
        /// <returns><see cref="SearchWordItemsResponse"/></returns>
        public async Task<SearchWordItemsResponse> SearchWordItems(SearchWordItemsRequest req)
        {
             JsonResponseModel<SearchWordItemsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SearchWordItems");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SearchWordItemsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询指定自定义词库中的词条是否存在。
        /// </summary>
        /// <param name="req"><see cref="SearchWordItemsRequest"/></param>
        /// <returns><see cref="SearchWordItemsResponse"/></returns>
        public SearchWordItemsResponse SearchWordItemsSync(SearchWordItemsRequest req)
        {
             JsonResponseModel<SearchWordItemsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SearchWordItems");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SearchWordItemsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 句向量接口能够将输入的句子映射成一个固定维度的向量，用来表示这个句子的语义特征，可用于文本聚类、文本相似度、文本分类等任务，能够显著提高它们的效果。
        /// 
        /// 该句向量服务由腾讯云自然语言处理团队联合微信智言团队共同打造，基于千亿级大规模互联网语料并采用Bert等领先的深度神经网络模型训练而成，在腾讯内部诸多业务的NLP任务上实测效果显著。
        /// </summary>
        /// <param name="req"><see cref="SentenceEmbeddingRequest"/></param>
        /// <returns><see cref="SentenceEmbeddingResponse"/></returns>
        public async Task<SentenceEmbeddingResponse> SentenceEmbedding(SentenceEmbeddingRequest req)
        {
             JsonResponseModel<SentenceEmbeddingResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SentenceEmbedding");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SentenceEmbeddingResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 句向量接口能够将输入的句子映射成一个固定维度的向量，用来表示这个句子的语义特征，可用于文本聚类、文本相似度、文本分类等任务，能够显著提高它们的效果。
        /// 
        /// 该句向量服务由腾讯云自然语言处理团队联合微信智言团队共同打造，基于千亿级大规模互联网语料并采用Bert等领先的深度神经网络模型训练而成，在腾讯内部诸多业务的NLP任务上实测效果显著。
        /// </summary>
        /// <param name="req"><see cref="SentenceEmbeddingRequest"/></param>
        /// <returns><see cref="SentenceEmbeddingResponse"/></returns>
        public SentenceEmbeddingResponse SentenceEmbeddingSync(SentenceEmbeddingRequest req)
        {
             JsonResponseModel<SentenceEmbeddingResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SentenceEmbedding");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SentenceEmbeddingResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 情感分析接口能够对带有情感色彩的主观性文本进行分析、处理、归纳和推理，识别出用户的情感倾向，是积极还是消极，并且提供各自概率。
        /// 
        /// 该功能基于千亿级大规模互联网语料和LSTM、BERT等深度神经网络模型进行训练，并持续迭代更新，以保证效果不断提升。
        /// </summary>
        /// <param name="req"><see cref="SentimentAnalysisRequest"/></param>
        /// <returns><see cref="SentimentAnalysisResponse"/></returns>
        public async Task<SentimentAnalysisResponse> SentimentAnalysis(SentimentAnalysisRequest req)
        {
             JsonResponseModel<SentimentAnalysisResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SentimentAnalysis");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SentimentAnalysisResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 情感分析接口能够对带有情感色彩的主观性文本进行分析、处理、归纳和推理，识别出用户的情感倾向，是积极还是消极，并且提供各自概率。
        /// 
        /// 该功能基于千亿级大规模互联网语料和LSTM、BERT等深度神经网络模型进行训练，并持续迭代更新，以保证效果不断提升。
        /// </summary>
        /// <param name="req"><see cref="SentimentAnalysisRequest"/></param>
        /// <returns><see cref="SentimentAnalysisResponse"/></returns>
        public SentimentAnalysisResponse SentimentAnalysisSync(SentimentAnalysisRequest req)
        {
             JsonResponseModel<SentimentAnalysisResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SentimentAnalysis");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SentimentAnalysisResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 相似词接口能够基于同义词库及词向量技术，检索出与输入词语在语义上最相似的若干个词语，可广泛用于检索系统、问答系统、文档归档等场景。
        /// </summary>
        /// <param name="req"><see cref="SimilarWordsRequest"/></param>
        /// <returns><see cref="SimilarWordsResponse"/></returns>
        public async Task<SimilarWordsResponse> SimilarWords(SimilarWordsRequest req)
        {
             JsonResponseModel<SimilarWordsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SimilarWords");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SimilarWordsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 相似词接口能够基于同义词库及词向量技术，检索出与输入词语在语义上最相似的若干个词语，可广泛用于检索系统、问答系统、文档归档等场景。
        /// </summary>
        /// <param name="req"><see cref="SimilarWordsRequest"/></param>
        /// <returns><see cref="SimilarWordsResponse"/></returns>
        public SimilarWordsResponse SimilarWordsSync(SimilarWordsRequest req)
        {
             JsonResponseModel<SimilarWordsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SimilarWords");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SimilarWordsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 文本分类接口能够对用户输入的文本进行自动分类，将其映射到具体的类目上，用户只需要提供待分类的文本，而无需关注具体实现。
        /// 
        /// 该功能基于千亿级大规模互联网语料和LSTM、BERT等深度神经网络模型进行训练，并持续迭代更新，以保证效果不断提升。
        /// 
        /// 目前已提供：
        /// 
        /// - 通用领域分类体系，包括15个分类类目，分别是汽车、科技、健康、体育、旅行、教育、职业、文化、军事、房产、娱乐、女性、奥运、财经以及其他，适用于通用的场景。
        /// 
        /// - 新闻领域分类体系，包括37个一级分类类目，285个二级分类（详细请见 [类目体系映射表](https://cloud.tencent.com/document/product/271/36459)），已应用于腾讯新闻的文章分类。
        /// 
        /// 更多垂直领域的分类体系即将推出，敬请期待。
        /// </summary>
        /// <param name="req"><see cref="TextClassificationRequest"/></param>
        /// <returns><see cref="TextClassificationResponse"/></returns>
        public async Task<TextClassificationResponse> TextClassification(TextClassificationRequest req)
        {
             JsonResponseModel<TextClassificationResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "TextClassification");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<TextClassificationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 文本分类接口能够对用户输入的文本进行自动分类，将其映射到具体的类目上，用户只需要提供待分类的文本，而无需关注具体实现。
        /// 
        /// 该功能基于千亿级大规模互联网语料和LSTM、BERT等深度神经网络模型进行训练，并持续迭代更新，以保证效果不断提升。
        /// 
        /// 目前已提供：
        /// 
        /// - 通用领域分类体系，包括15个分类类目，分别是汽车、科技、健康、体育、旅行、教育、职业、文化、军事、房产、娱乐、女性、奥运、财经以及其他，适用于通用的场景。
        /// 
        /// - 新闻领域分类体系，包括37个一级分类类目，285个二级分类（详细请见 [类目体系映射表](https://cloud.tencent.com/document/product/271/36459)），已应用于腾讯新闻的文章分类。
        /// 
        /// 更多垂直领域的分类体系即将推出，敬请期待。
        /// </summary>
        /// <param name="req"><see cref="TextClassificationRequest"/></param>
        /// <returns><see cref="TextClassificationResponse"/></returns>
        public TextClassificationResponse TextClassificationSync(TextClassificationRequest req)
        {
             JsonResponseModel<TextClassificationResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "TextClassification");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<TextClassificationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 提供对中文文本的自动纠错功能，能够识别输入文本中的错误片段，定位错误并给出正确的文本结果；支持长度不超过2000字的长文本纠错。
        /// 
        /// 此功能是基于千亿级大规模互联网语料和LSTM、BERT等深度神经网络模型进行训练，并持续迭代更新，以保证效果不断提升，是搜索引擎、语音识别、内容审核等功能更好运行的基础之一。 
        /// </summary>
        /// <param name="req"><see cref="TextCorrectionRequest"/></param>
        /// <returns><see cref="TextCorrectionResponse"/></returns>
        public async Task<TextCorrectionResponse> TextCorrection(TextCorrectionRequest req)
        {
             JsonResponseModel<TextCorrectionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "TextCorrection");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<TextCorrectionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 提供对中文文本的自动纠错功能，能够识别输入文本中的错误片段，定位错误并给出正确的文本结果；支持长度不超过2000字的长文本纠错。
        /// 
        /// 此功能是基于千亿级大规模互联网语料和LSTM、BERT等深度神经网络模型进行训练，并持续迭代更新，以保证效果不断提升，是搜索引擎、语音识别、内容审核等功能更好运行的基础之一。 
        /// </summary>
        /// <param name="req"><see cref="TextCorrectionRequest"/></param>
        /// <returns><see cref="TextCorrectionResponse"/></returns>
        public TextCorrectionResponse TextCorrectionSync(TextCorrectionRequest req)
        {
             JsonResponseModel<TextCorrectionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "TextCorrection");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<TextCorrectionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 句子相似度接口能够基于深度学习技术来计算一个源句子和多个目标句子的相似度，相似度分值越大的两个句子在语义上越相似。目前仅支持短文本（不超过500字符）的相似度计算，长文本的相似度计算也即将推出。
        /// 
        /// 鉴于句子相似度是一个应用非常广泛的功能，腾讯云自然语言处理团队在Bert等领先的深度神经网络模型的基础上，专门针对文本相似任务进行了优化，并持续迭代更新。基于句子相似度，可以轻松实现诸如文本去重、相似推荐等功能。
        /// </summary>
        /// <param name="req"><see cref="TextSimilarityRequest"/></param>
        /// <returns><see cref="TextSimilarityResponse"/></returns>
        public async Task<TextSimilarityResponse> TextSimilarity(TextSimilarityRequest req)
        {
             JsonResponseModel<TextSimilarityResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "TextSimilarity");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<TextSimilarityResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 句子相似度接口能够基于深度学习技术来计算一个源句子和多个目标句子的相似度，相似度分值越大的两个句子在语义上越相似。目前仅支持短文本（不超过500字符）的相似度计算，长文本的相似度计算也即将推出。
        /// 
        /// 鉴于句子相似度是一个应用非常广泛的功能，腾讯云自然语言处理团队在Bert等领先的深度神经网络模型的基础上，专门针对文本相似任务进行了优化，并持续迭代更新。基于句子相似度，可以轻松实现诸如文本去重、相似推荐等功能。
        /// </summary>
        /// <param name="req"><see cref="TextSimilarityRequest"/></param>
        /// <returns><see cref="TextSimilarityResponse"/></returns>
        public TextSimilarityResponse TextSimilaritySync(TextSimilarityRequest req)
        {
             JsonResponseModel<TextSimilarityResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "TextSimilarity");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<TextSimilarityResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改自定义词库元数据信息，包括名称、描述。
        /// </summary>
        /// <param name="req"><see cref="UpdateDictRequest"/></param>
        /// <returns><see cref="UpdateDictResponse"/></returns>
        public async Task<UpdateDictResponse> UpdateDict(UpdateDictRequest req)
        {
             JsonResponseModel<UpdateDictResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpdateDict");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateDictResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改自定义词库元数据信息，包括名称、描述。
        /// </summary>
        /// <param name="req"><see cref="UpdateDictRequest"/></param>
        /// <returns><see cref="UpdateDictResponse"/></returns>
        public UpdateDictResponse UpdateDictSync(UpdateDictRequest req)
        {
             JsonResponseModel<UpdateDictResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpdateDict");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateDictResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 词向量接口能够将输入的词语映射成一个固定维度的词向量，用来表示这个词语的语义特征。词向量是很多自然语言处理技术的基础，能够显著提高它们的效果。
        /// 
        /// 该词向量服务由腾讯知文自然语言处理团队联合腾讯AI Lab共同打造。使用的词向量基于千亿级大规模互联网语料并采用AI Lab自研的DSG算法训练而成，开源的词向量包含800多万中文词汇，在覆盖率、新鲜度及准确性等三方面性能突出。
        /// 
        /// 腾讯AI Lab词向量相关资料：
        /// 
        /// https://ai.tencent.com/ailab/zh/news/detial?id=22
        /// 
        /// https://ai.tencent.com/ailab/nlp/zh/embedding.html
        /// </summary>
        /// <param name="req"><see cref="WordEmbeddingRequest"/></param>
        /// <returns><see cref="WordEmbeddingResponse"/></returns>
        public async Task<WordEmbeddingResponse> WordEmbedding(WordEmbeddingRequest req)
        {
             JsonResponseModel<WordEmbeddingResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "WordEmbedding");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<WordEmbeddingResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 词向量接口能够将输入的词语映射成一个固定维度的词向量，用来表示这个词语的语义特征。词向量是很多自然语言处理技术的基础，能够显著提高它们的效果。
        /// 
        /// 该词向量服务由腾讯知文自然语言处理团队联合腾讯AI Lab共同打造。使用的词向量基于千亿级大规模互联网语料并采用AI Lab自研的DSG算法训练而成，开源的词向量包含800多万中文词汇，在覆盖率、新鲜度及准确性等三方面性能突出。
        /// 
        /// 腾讯AI Lab词向量相关资料：
        /// 
        /// https://ai.tencent.com/ailab/zh/news/detial?id=22
        /// 
        /// https://ai.tencent.com/ailab/nlp/zh/embedding.html
        /// </summary>
        /// <param name="req"><see cref="WordEmbeddingRequest"/></param>
        /// <returns><see cref="WordEmbeddingResponse"/></returns>
        public WordEmbeddingResponse WordEmbeddingSync(WordEmbeddingRequest req)
        {
             JsonResponseModel<WordEmbeddingResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "WordEmbedding");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<WordEmbeddingResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 词相似度接口能够基于词向量技术来计算两个输入词语的余弦相似度，相似度数值越大的两个词语在语义上越相似。
        /// </summary>
        /// <param name="req"><see cref="WordSimilarityRequest"/></param>
        /// <returns><see cref="WordSimilarityResponse"/></returns>
        public async Task<WordSimilarityResponse> WordSimilarity(WordSimilarityRequest req)
        {
             JsonResponseModel<WordSimilarityResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "WordSimilarity");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<WordSimilarityResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 词相似度接口能够基于词向量技术来计算两个输入词语的余弦相似度，相似度数值越大的两个词语在语义上越相似。
        /// </summary>
        /// <param name="req"><see cref="WordSimilarityRequest"/></param>
        /// <returns><see cref="WordSimilarityResponse"/></returns>
        public WordSimilarityResponse WordSimilaritySync(WordSimilarityRequest req)
        {
             JsonResponseModel<WordSimilarityResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "WordSimilarity");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<WordSimilarityResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
