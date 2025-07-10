/*
 * Copyright (c) 2018 Tencent. All Rights Reserved.
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
       private const string sdkVersion = "SDK_NET_3.0.1277";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public NlpClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
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
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 情感分析接口能够对带有情感色彩的主观性文本进行分析、处理、归纳和推理，识别出用户的情感倾向，是积极、中性还是消极，并且提供各自概率。
        /// </summary>
        /// <param name="req"><see cref="AnalyzeSentimentRequest"/></param>
        /// <returns><see cref="AnalyzeSentimentResponse"/></returns>
        public Task<AnalyzeSentimentResponse> AnalyzeSentiment(AnalyzeSentimentRequest req)
        {
            return InternalRequestAsync<AnalyzeSentimentResponse>(req, "AnalyzeSentiment");
        }

        /// <summary>
        /// 情感分析接口能够对带有情感色彩的主观性文本进行分析、处理、归纳和推理，识别出用户的情感倾向，是积极、中性还是消极，并且提供各自概率。
        /// </summary>
        /// <param name="req"><see cref="AnalyzeSentimentRequest"/></param>
        /// <returns><see cref="AnalyzeSentimentResponse"/></returns>
        public AnalyzeSentimentResponse AnalyzeSentimentSync(AnalyzeSentimentRequest req)
        {
            return InternalRequestAsync<AnalyzeSentimentResponse>(req, "AnalyzeSentiment")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 文本分类接口能够对用户输入的文章进行自动分类，将其映射到具体的类目上，用户只需要提供待分类的文本，而无需关注具体实现。该功能定义了一套较为完备的[三级分类体系](https://cloud.tencent.com/document/product/271/94286)，积累了数百万的语料，经过多轮迭代优化打造了较先进的深度学习模型，以保证效果不断提升。
        /// </summary>
        /// <param name="req"><see cref="ClassifyContentRequest"/></param>
        /// <returns><see cref="ClassifyContentResponse"/></returns>
        public Task<ClassifyContentResponse> ClassifyContent(ClassifyContentRequest req)
        {
            return InternalRequestAsync<ClassifyContentResponse>(req, "ClassifyContent");
        }

        /// <summary>
        /// 文本分类接口能够对用户输入的文章进行自动分类，将其映射到具体的类目上，用户只需要提供待分类的文本，而无需关注具体实现。该功能定义了一套较为完备的[三级分类体系](https://cloud.tencent.com/document/product/271/94286)，积累了数百万的语料，经过多轮迭代优化打造了较先进的深度学习模型，以保证效果不断提升。
        /// </summary>
        /// <param name="req"><see cref="ClassifyContentRequest"/></param>
        /// <returns><see cref="ClassifyContentResponse"/></returns>
        public ClassifyContentResponse ClassifyContentSync(ClassifyContentRequest req)
        {
            return InternalRequestAsync<ClassifyContentResponse>(req, "ClassifyContent")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 对联生成接口根据用户输入的命题关键词，智能生成一副完整的春联，包括上联、下联和横批。该接口利用先进的自然语言处理技术，确保生成的春联既符合传统对仗、对韵、对义的要求，又具有新意和创意，为用户提供独特的春节祝福。
        /// </summary>
        /// <param name="req"><see cref="ComposeCoupletRequest"/></param>
        /// <returns><see cref="ComposeCoupletResponse"/></returns>
        public Task<ComposeCoupletResponse> ComposeCouplet(ComposeCoupletRequest req)
        {
            return InternalRequestAsync<ComposeCoupletResponse>(req, "ComposeCouplet");
        }

        /// <summary>
        /// 对联生成接口根据用户输入的命题关键词，智能生成一副完整的春联，包括上联、下联和横批。该接口利用先进的自然语言处理技术，确保生成的春联既符合传统对仗、对韵、对义的要求，又具有新意和创意，为用户提供独特的春节祝福。
        /// </summary>
        /// <param name="req"><see cref="ComposeCoupletRequest"/></param>
        /// <returns><see cref="ComposeCoupletResponse"/></returns>
        public ComposeCoupletResponse ComposeCoupletSync(ComposeCoupletRequest req)
        {
            return InternalRequestAsync<ComposeCoupletResponse>(req, "ComposeCouplet")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 通过计算句子间的语义相似性，帮助您快速找到文本中重复或相似的句子，用于文本聚类、相似问题检索等应用场景。
        /// </summary>
        /// <param name="req"><see cref="EvaluateSentenceSimilarityRequest"/></param>
        /// <returns><see cref="EvaluateSentenceSimilarityResponse"/></returns>
        public Task<EvaluateSentenceSimilarityResponse> EvaluateSentenceSimilarity(EvaluateSentenceSimilarityRequest req)
        {
            return InternalRequestAsync<EvaluateSentenceSimilarityResponse>(req, "EvaluateSentenceSimilarity");
        }

        /// <summary>
        /// 通过计算句子间的语义相似性，帮助您快速找到文本中重复或相似的句子，用于文本聚类、相似问题检索等应用场景。
        /// </summary>
        /// <param name="req"><see cref="EvaluateSentenceSimilarityRequest"/></param>
        /// <returns><see cref="EvaluateSentenceSimilarityResponse"/></returns>
        public EvaluateSentenceSimilarityResponse EvaluateSentenceSimilaritySync(EvaluateSentenceSimilarityRequest req)
        {
            return InternalRequestAsync<EvaluateSentenceSimilarityResponse>(req, "EvaluateSentenceSimilarity")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 通过精准地对文本进行分词、词性标注、命名实体识别等功能，助您更好地理解文本内容，挖掘出潜在的价值信息。
        /// </summary>
        /// <param name="req"><see cref="ParseWordsRequest"/></param>
        /// <returns><see cref="ParseWordsResponse"/></returns>
        public Task<ParseWordsResponse> ParseWords(ParseWordsRequest req)
        {
            return InternalRequestAsync<ParseWordsResponse>(req, "ParseWords");
        }

        /// <summary>
        /// 通过精准地对文本进行分词、词性标注、命名实体识别等功能，助您更好地理解文本内容，挖掘出潜在的价值信息。
        /// </summary>
        /// <param name="req"><see cref="ParseWordsRequest"/></param>
        /// <returns><see cref="ParseWordsResponse"/></returns>
        public ParseWordsResponse ParseWordsSync(ParseWordsRequest req)
        {
            return InternalRequestAsync<ParseWordsResponse>(req, "ParseWords")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 智能识别并纠正句子中的语法、拼写、用词等错误，确保文本的准确性和可读性。
        /// </summary>
        /// <param name="req"><see cref="SentenceCorrectionRequest"/></param>
        /// <returns><see cref="SentenceCorrectionResponse"/></returns>
        public Task<SentenceCorrectionResponse> SentenceCorrection(SentenceCorrectionRequest req)
        {
            return InternalRequestAsync<SentenceCorrectionResponse>(req, "SentenceCorrection");
        }

        /// <summary>
        /// 智能识别并纠正句子中的语法、拼写、用词等错误，确保文本的准确性和可读性。
        /// </summary>
        /// <param name="req"><see cref="SentenceCorrectionRequest"/></param>
        /// <returns><see cref="SentenceCorrectionResponse"/></returns>
        public SentenceCorrectionResponse SentenceCorrectionSync(SentenceCorrectionRequest req)
        {
            return InternalRequestAsync<SentenceCorrectionResponse>(req, "SentenceCorrection")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
