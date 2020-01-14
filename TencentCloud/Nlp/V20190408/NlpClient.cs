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
        /// AutoSummarization接口的同步版本，利用人工智能算法，自动抽取文本中的关键信息并生成指定长度的文本摘要。可用于新闻标题生成、科技文献摘要生成和商品评论摘要等。
        /// </summary>
        /// <param name="req">参考<see cref="AutoSummarizationRequest"/></param>
        /// <returns>参考<see cref="AutoSummarizationResponse"/>实例</returns>
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
        /// ChatBot接口的同步版本，闲聊服务基于腾讯领先的NLP引擎能力、数据运算能力和千亿级互联网语料数据的支持，同时集成了广泛的知识问答能力，可实现上百种自定义属性配置，以及儿童语言风格及说话方式，从而让聊天变得更睿智、简单和有趣。
        /// 
        /// </summary>
        /// <param name="req">参考<see cref="ChatBotRequest"/></param>
        /// <returns>参考<see cref="ChatBotResponse"/>实例</returns>
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
        /// DependencyParsing接口的同步版本，句法依存分析接口能够分析出句子中词与词之间的相互依存关系，并揭示其句法结构，包括主谓关系、动宾关系、核心关系等等，可用于提取句子主干、提取句子核心词等，在机器翻译、自动问答、知识抽取等领域都有很好的应用。
        /// </summary>
        /// <param name="req">参考<see cref="DependencyParsingRequest"/></param>
        /// <returns>参考<see cref="DependencyParsingResponse"/>实例</returns>
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
        /// DescribeEntity接口的同步版本，输入实体名称，返回实体相关的信息如实体别名、实体英文名、实体详细信息、相关实体等。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeEntityRequest"/></param>
        /// <returns>参考<see cref="DescribeEntityResponse"/>实例</returns>
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
        /// DescribeRelation接口的同步版本，输入两个实体，返回两个实体间的关系，例如马化腾与腾讯公司不仅是相关实体，二者还存在隶属关系（马化腾属于腾讯公司）。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeRelationRequest"/></param>
        /// <returns>参考<see cref="DescribeRelationResponse"/>实例</returns>
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
        /// DescribeTriple接口的同步版本，三元组查询，主要分为两类，SP查询和PO查询。SP查询表示已知主语和谓语查询宾语，PO查询表示已知宾语和谓语查询主语。每一个SP或PO查询都是一个可独立执行的查询，TQL支持SP查询的嵌套查询，即主语可以是一个嵌套的子查询。其他复杂的三元组查询方法，请参考官网API文档示例。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeTripleRequest"/></param>
        /// <returns>参考<see cref="DescribeTripleResponse"/>实例</returns>
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
        /// KeywordsExtraction接口的同步版本，基于关键词提取平台，通过对文本内容进行深度分析，提取出文本内容中的关键信息，为用户实现诸如新闻内容关键词自动提取、评论关键词提取等提供基础服务。
        /// </summary>
        /// <param name="req">参考<see cref="KeywordsExtractionRequest"/></param>
        /// <returns>参考<see cref="KeywordsExtractionResponse"/>实例</returns>
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
        /// LexicalAnalysis接口的同步版本，词法分析接口提供以下三个功能：
        /// 
        /// 1、智能分词：将连续的自然语言文本，切分成具有语义合理性和完整性的词汇序列；
        /// 
        /// 2、词性标注：为每一个词附上对应的词性，例如名词、代词、形容词、动词等；
        /// 
        /// 3、命名实体识别：快速识别文本中的实体，例如人名、地名、机构名等。
        /// 
        /// 所有的功能均基于千亿级大规模互联网语料进行持续迭代更新，以保证效果不断提升，用户无需担心新词发现、歧义消除、调用性能等问题。目前词法分析已经在泛互联网、金融、政务等不同垂直领域提供业务支持，并取得良好的效果。
        /// </summary>
        /// <param name="req">参考<see cref="LexicalAnalysisRequest"/></param>
        /// <returns>参考<see cref="LexicalAnalysisResponse"/>实例</returns>
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
        /// 敏感词识别接口能够识别出文本中的所有敏感词，帮助用户及时、精准地防范违规风险，广泛用于各种高危涉敏场景（如资讯、评论、聊天室）的敏感信息过滤。
        /// 
        /// 该功能基于10万级大规模敏感词库，结合多种文本对抗方法、政策权威指令等，高效识别敏感词及其各类变种。同时我们会根据大规模语料和实时反误杀系统，不断更新迭代，确保效果持续提升。
        /// 
        /// 目前能够支持对政治、色情、辱骂/低俗、暴恐/毒品、广告/灌水、迷信/邪教、其他违法、综合等8大类敏感信息的识别。
        /// </summary>
        /// <param name="req"><see cref="SensitiveWordsRecognitionRequest"/></param>
        /// <returns><see cref="SensitiveWordsRecognitionResponse"/></returns>
        public async Task<SensitiveWordsRecognitionResponse> SensitiveWordsRecognition(SensitiveWordsRecognitionRequest req)
        {
             JsonResponseModel<SensitiveWordsRecognitionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SensitiveWordsRecognition");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SensitiveWordsRecognitionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// SensitiveWordsRecognition接口的同步版本，敏感词识别接口能够识别出文本中的所有敏感词，帮助用户及时、精准地防范违规风险，广泛用于各种高危涉敏场景（如资讯、评论、聊天室）的敏感信息过滤。
        /// 
        /// 该功能基于10万级大规模敏感词库，结合多种文本对抗方法、政策权威指令等，高效识别敏感词及其各类变种。同时我们会根据大规模语料和实时反误杀系统，不断更新迭代，确保效果持续提升。
        /// 
        /// 目前能够支持对政治、色情、辱骂/低俗、暴恐/毒品、广告/灌水、迷信/邪教、其他违法、综合等8大类敏感信息的识别。
        /// </summary>
        /// <param name="req">参考<see cref="SensitiveWordsRecognitionRequest"/></param>
        /// <returns>参考<see cref="SensitiveWordsRecognitionResponse"/>实例</returns>
        public SensitiveWordsRecognitionResponse SensitiveWordsRecognitionSync(SensitiveWordsRecognitionRequest req)
        {
             JsonResponseModel<SensitiveWordsRecognitionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SensitiveWordsRecognition");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SensitiveWordsRecognitionResponse>>(strResp);
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
        /// 该句向量服务由腾讯知文自然语言处理团队联合腾讯AI Lab共同打造，基于千亿级大规模互联网语料并采用AI Lab自研的DSG算法训练而成，在腾讯内部诸多业务的NLP任务上实测效果显著。
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
        /// SentenceEmbedding接口的同步版本，句向量接口能够将输入的句子映射成一个固定维度的向量，用来表示这个句子的语义特征，可用于文本聚类、文本相似度、文本分类等任务，能够显著提高它们的效果。
        /// 
        /// 该句向量服务由腾讯知文自然语言处理团队联合腾讯AI Lab共同打造，基于千亿级大规模互联网语料并采用AI Lab自研的DSG算法训练而成，在腾讯内部诸多业务的NLP任务上实测效果显著。
        /// </summary>
        /// <param name="req">参考<see cref="SentenceEmbeddingRequest"/></param>
        /// <returns>参考<see cref="SentenceEmbeddingResponse"/>实例</returns>
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
        /// 文本相似度接口能够基于深度学习技术来计算两个输入文本的相似度，相似度数值越大的两个文本在语义上越相似。目前仅支持短文本的相似度计算，长文本的相似度计算也即将推出。
        /// 
        /// 鉴于文本相似度是一个应用非常广泛的功能，腾讯知文自然语言处理团队在深度神经网络模型的基础上，专门针对文本相似任务进行了优化，并持续迭代更新。基于文本相似度，可以轻松实现诸如文本去重、相似推荐等功能。
        /// </summary>
        /// <param name="req"><see cref="SentenceSimilarityRequest"/></param>
        /// <returns><see cref="SentenceSimilarityResponse"/></returns>
        public async Task<SentenceSimilarityResponse> SentenceSimilarity(SentenceSimilarityRequest req)
        {
             JsonResponseModel<SentenceSimilarityResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SentenceSimilarity");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SentenceSimilarityResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// SentenceSimilarity接口的同步版本，文本相似度接口能够基于深度学习技术来计算两个输入文本的相似度，相似度数值越大的两个文本在语义上越相似。目前仅支持短文本的相似度计算，长文本的相似度计算也即将推出。
        /// 
        /// 鉴于文本相似度是一个应用非常广泛的功能，腾讯知文自然语言处理团队在深度神经网络模型的基础上，专门针对文本相似任务进行了优化，并持续迭代更新。基于文本相似度，可以轻松实现诸如文本去重、相似推荐等功能。
        /// </summary>
        /// <param name="req">参考<see cref="SentenceSimilarityRequest"/></param>
        /// <returns>参考<see cref="SentenceSimilarityResponse"/>实例</returns>
        public SentenceSimilarityResponse SentenceSimilaritySync(SentenceSimilarityRequest req)
        {
             JsonResponseModel<SentenceSimilarityResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SentenceSimilarity");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SentenceSimilarityResponse>>(strResp);
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
        /// 该功能基于基于千亿级大规模互联网语料和LSTM、BERT等深度神经网络模型进行训练，并持续迭代更新，以保证效果不断提升。
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
        /// SentimentAnalysis接口的同步版本，情感分析接口能够对带有情感色彩的主观性文本进行分析、处理、归纳和推理，识别出用户的情感倾向，是积极还是消极，并且提供各自概率。
        /// 
        /// 该功能基于基于千亿级大规模互联网语料和LSTM、BERT等深度神经网络模型进行训练，并持续迭代更新，以保证效果不断提升。
        /// </summary>
        /// <param name="req">参考<see cref="SentimentAnalysisRequest"/></param>
        /// <returns>参考<see cref="SentimentAnalysisResponse"/>实例</returns>
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
        /// SimilarWords接口的同步版本，相似词接口能够基于同义词库及词向量技术，检索出与输入词语在语义上最相似的若干个词语，可广泛用于检索系统、问答系统、文档归档等场景。
        /// </summary>
        /// <param name="req">参考<see cref="SimilarWordsRequest"/></param>
        /// <returns>参考<see cref="SimilarWordsResponse"/>实例</returns>
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
        /// 文本审核接口能够识别文本信息中的色情、政治等有害内容，帮助用户及时、精准地防范违规风险，可用于内容审核、敏感信息过滤、舆情监控等场景。
        /// 
        /// 该功能基于10万级大规模敏感词库，结合多种文本对抗方法、政策权威指令等，并运用了深度学习技术，高效识别高危有害内容。同时我们会根据大规模语料和实时反误杀系统，不断更新迭代，确保效果持续提升。
        /// 
        /// 文本审核接口目前提供以下三个功能：
        /// 
        /// 1、文本恶意级别：将文本分为3个级别，包括正常、恶意、可疑送审；
        /// 
        /// 2、文本恶意类型：把文本分为10个类别，包括正常、政治、色情、辱骂/低俗、暴恐/毒品、广告/灌水、迷信/邪教、其他违法、综合、联系方式/链接；
        /// 
        /// 3、恶意关键词：文本中所有涉嫌恶意的关键词。
        /// </summary>
        /// <param name="req"><see cref="TextApprovalRequest"/></param>
        /// <returns><see cref="TextApprovalResponse"/></returns>
        public async Task<TextApprovalResponse> TextApproval(TextApprovalRequest req)
        {
             JsonResponseModel<TextApprovalResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "TextApproval");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<TextApprovalResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// TextApproval接口的同步版本，文本审核接口能够识别文本信息中的色情、政治等有害内容，帮助用户及时、精准地防范违规风险，可用于内容审核、敏感信息过滤、舆情监控等场景。
        /// 
        /// 该功能基于10万级大规模敏感词库，结合多种文本对抗方法、政策权威指令等，并运用了深度学习技术，高效识别高危有害内容。同时我们会根据大规模语料和实时反误杀系统，不断更新迭代，确保效果持续提升。
        /// 
        /// 文本审核接口目前提供以下三个功能：
        /// 
        /// 1、文本恶意级别：将文本分为3个级别，包括正常、恶意、可疑送审；
        /// 
        /// 2、文本恶意类型：把文本分为10个类别，包括正常、政治、色情、辱骂/低俗、暴恐/毒品、广告/灌水、迷信/邪教、其他违法、综合、联系方式/链接；
        /// 
        /// 3、恶意关键词：文本中所有涉嫌恶意的关键词。
        /// </summary>
        /// <param name="req">参考<see cref="TextApprovalRequest"/></param>
        /// <returns>参考<see cref="TextApprovalResponse"/>实例</returns>
        public TextApprovalResponse TextApprovalSync(TextApprovalRequest req)
        {
             JsonResponseModel<TextApprovalResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "TextApproval");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<TextApprovalResponse>>(strResp);
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
        /// 该功能基于基于千亿级大规模互联网语料和LSTM、BERT等深度神经网络模型进行训练，并持续迭代更新，以保证效果不断提升。
        /// 
        /// 目前已提供：
        /// 
        /// - 通用领域分类体系，包括15个分类类目，分别是汽车、科技、健康、体育、旅行、教育、职业、文化、军事、房产、娱乐、女性、奥运、财经以及其他，适用于通用的场景。
        /// 
        /// - 新闻领域分类体系，包括37个一级分类类目，285个二级分类，已应用于腾讯新闻的文章分类。
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
        /// TextClassification接口的同步版本，文本分类接口能够对用户输入的文本进行自动分类，将其映射到具体的类目上，用户只需要提供待分类的文本，而无需关注具体实现。
        /// 
        /// 该功能基于基于千亿级大规模互联网语料和LSTM、BERT等深度神经网络模型进行训练，并持续迭代更新，以保证效果不断提升。
        /// 
        /// 目前已提供：
        /// 
        /// - 通用领域分类体系，包括15个分类类目，分别是汽车、科技、健康、体育、旅行、教育、职业、文化、军事、房产、娱乐、女性、奥运、财经以及其他，适用于通用的场景。
        /// 
        /// - 新闻领域分类体系，包括37个一级分类类目，285个二级分类，已应用于腾讯新闻的文章分类。
        /// 
        /// 更多垂直领域的分类体系即将推出，敬请期待。
        /// </summary>
        /// <param name="req">参考<see cref="TextClassificationRequest"/></param>
        /// <returns>参考<see cref="TextClassificationResponse"/>实例</returns>
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
        /// TextCorrection接口的同步版本，提供对中文文本的自动纠错功能，能够识别输入文本中的错误片段，定位错误并给出正确的文本结果；支持长度不超过2000字的长文本纠错。
        /// 
        /// 此功能是基于千亿级大规模互联网语料和LSTM、BERT等深度神经网络模型进行训练，并持续迭代更新，以保证效果不断提升，是搜索引擎、语音识别、内容审核等功能更好运行的基础之一。 
        /// </summary>
        /// <param name="req">参考<see cref="TextCorrectionRequest"/></param>
        /// <returns>参考<see cref="TextCorrectionResponse"/>实例</returns>
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
        /// 词向量接口能够将输入的词语映射成一个固定维度的词向量，用来表示这个词语的语义特征。词向量是很多自然语言处理技术的基础，能够显著提高它们的效果。
        /// 
        /// 该词向量服务由腾讯知文自然语言处理团队联合腾讯AI Lab共同打造。使用的词向量基于千亿级大规模互联网语料并采用AI Lab自研的DSG算法训练而成，开源的词向量包含800多万中文词汇，在覆盖率、新鲜度及准确性等三方面性能突出。
        /// 
        /// 腾讯AI Lab词向量相关资料：
        /// 
        /// https://ai.tencent.com/ailab/zh/news/detial?id=22
        /// 
        /// https://ai.tencent.com/ailab/nlp/embedding.html 
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
        /// WordEmbedding接口的同步版本，词向量接口能够将输入的词语映射成一个固定维度的词向量，用来表示这个词语的语义特征。词向量是很多自然语言处理技术的基础，能够显著提高它们的效果。
        /// 
        /// 该词向量服务由腾讯知文自然语言处理团队联合腾讯AI Lab共同打造。使用的词向量基于千亿级大规模互联网语料并采用AI Lab自研的DSG算法训练而成，开源的词向量包含800多万中文词汇，在覆盖率、新鲜度及准确性等三方面性能突出。
        /// 
        /// 腾讯AI Lab词向量相关资料：
        /// 
        /// https://ai.tencent.com/ailab/zh/news/detial?id=22
        /// 
        /// https://ai.tencent.com/ailab/nlp/embedding.html 
        /// </summary>
        /// <param name="req">参考<see cref="WordEmbeddingRequest"/></param>
        /// <returns>参考<see cref="WordEmbeddingResponse"/>实例</returns>
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
        /// WordSimilarity接口的同步版本，词相似度接口能够基于词向量技术来计算两个输入词语的余弦相似度，相似度数值越大的两个词语在语义上越相似。
        /// </summary>
        /// <param name="req">参考<see cref="WordSimilarityRequest"/></param>
        /// <returns>参考<see cref="WordSimilarityResponse"/>实例</returns>
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
