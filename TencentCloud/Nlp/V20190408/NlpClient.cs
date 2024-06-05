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
       private const string sdkVersion = "SDK_NET_3.0.1021";

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
        /// 诗词生成接口利用现代的自然语言处理和深度学习技术，模仿了古代著名诗人的风格，为用户产生独特的诗词。用户只需输入的命题关键词，接口就能自动生成一首七言律诗或五言律诗。
        /// </summary>
        /// <param name="req"><see cref="ComposePoetryRequest"/></param>
        /// <returns><see cref="ComposePoetryResponse"/></returns>
        public Task<ComposePoetryResponse> ComposePoetry(ComposePoetryRequest req)
        {
            return InternalRequestAsync<ComposePoetryResponse>(req, "ComposePoetry");
        }

        /// <summary>
        /// 诗词生成接口利用现代的自然语言处理和深度学习技术，模仿了古代著名诗人的风格，为用户产生独特的诗词。用户只需输入的命题关键词，接口就能自动生成一首七言律诗或五言律诗。
        /// </summary>
        /// <param name="req"><see cref="ComposePoetryRequest"/></param>
        /// <returns><see cref="ComposePoetryResponse"/></returns>
        public ComposePoetryResponse ComposePoetrySync(ComposePoetryRequest req)
        {
            return InternalRequestAsync<ComposePoetryResponse>(req, "ComposePoetry")
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
        /// 评估两个词语在语义空间的相似程度，为您的场景应用提供有力支持，如关键词过滤、热门话题挖掘等。（目前仅支持中文）
        /// </summary>
        /// <param name="req"><see cref="EvaluateWordSimilarityRequest"/></param>
        /// <returns><see cref="EvaluateWordSimilarityResponse"/></returns>
        public Task<EvaluateWordSimilarityResponse> EvaluateWordSimilarity(EvaluateWordSimilarityRequest req)
        {
            return InternalRequestAsync<EvaluateWordSimilarityResponse>(req, "EvaluateWordSimilarity");
        }

        /// <summary>
        /// 评估两个词语在语义空间的相似程度，为您的场景应用提供有力支持，如关键词过滤、热门话题挖掘等。（目前仅支持中文）
        /// </summary>
        /// <param name="req"><see cref="EvaluateWordSimilarityRequest"/></param>
        /// <returns><see cref="EvaluateWordSimilarityResponse"/></returns>
        public EvaluateWordSimilarityResponse EvaluateWordSimilaritySync(EvaluateWordSimilarityRequest req)
        {
            return InternalRequestAsync<EvaluateWordSimilarityResponse>(req, "EvaluateWordSimilarity")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 根据提供的关键词，生成简洁明了的关键句子，便于用户快速获取核心观点。
        /// </summary>
        /// <param name="req"><see cref="GenerateKeywordSentenceRequest"/></param>
        /// <returns><see cref="GenerateKeywordSentenceResponse"/></returns>
        public Task<GenerateKeywordSentenceResponse> GenerateKeywordSentence(GenerateKeywordSentenceRequest req)
        {
            return InternalRequestAsync<GenerateKeywordSentenceResponse>(req, "GenerateKeywordSentence");
        }

        /// <summary>
        /// 根据提供的关键词，生成简洁明了的关键句子，便于用户快速获取核心观点。
        /// </summary>
        /// <param name="req"><see cref="GenerateKeywordSentenceRequest"/></param>
        /// <returns><see cref="GenerateKeywordSentenceResponse"/></returns>
        public GenerateKeywordSentenceResponse GenerateKeywordSentenceSync(GenerateKeywordSentenceRequest req)
        {
            return InternalRequestAsync<GenerateKeywordSentenceResponse>(req, "GenerateKeywordSentence")
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
        /// 基于大数据和深度学习技术，可以快速地找到与给定词语高度相似的其他词语，有助于提高搜索和推荐的准确性。（目前仅支持中文）
        /// </summary>
        /// <param name="req"><see cref="RetrieveSimilarWordsRequest"/></param>
        /// <returns><see cref="RetrieveSimilarWordsResponse"/></returns>
        public Task<RetrieveSimilarWordsResponse> RetrieveSimilarWords(RetrieveSimilarWordsRequest req)
        {
            return InternalRequestAsync<RetrieveSimilarWordsResponse>(req, "RetrieveSimilarWords");
        }

        /// <summary>
        /// 基于大数据和深度学习技术，可以快速地找到与给定词语高度相似的其他词语，有助于提高搜索和推荐的准确性。（目前仅支持中文）
        /// </summary>
        /// <param name="req"><see cref="RetrieveSimilarWordsRequest"/></param>
        /// <returns><see cref="RetrieveSimilarWordsResponse"/></returns>
        public RetrieveSimilarWordsResponse RetrieveSimilarWordsSync(RetrieveSimilarWordsRequest req)
        {
            return InternalRequestAsync<RetrieveSimilarWordsResponse>(req, "RetrieveSimilarWords")
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

        /// <summary>
        /// 运用先进的自然语言处理技术，对原始文本进行优化润色，提升文本的通顺性、表达力和语言质量。
        /// </summary>
        /// <param name="req"><see cref="TextEmbellishRequest"/></param>
        /// <returns><see cref="TextEmbellishResponse"/></returns>
        public Task<TextEmbellishResponse> TextEmbellish(TextEmbellishRequest req)
        {
            return InternalRequestAsync<TextEmbellishResponse>(req, "TextEmbellish");
        }

        /// <summary>
        /// 运用先进的自然语言处理技术，对原始文本进行优化润色，提升文本的通顺性、表达力和语言质量。
        /// </summary>
        /// <param name="req"><see cref="TextEmbellishRequest"/></param>
        /// <returns><see cref="TextEmbellishResponse"/></returns>
        public TextEmbellishResponse TextEmbellishSync(TextEmbellishRequest req)
        {
            return InternalRequestAsync<TextEmbellishResponse>(req, "TextEmbellish")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 通过自动补全文本片段，帮助用户快速生成高质量、连贯的完整文本，提高创作效率。
        /// </summary>
        /// <param name="req"><see cref="TextWritingRequest"/></param>
        /// <returns><see cref="TextWritingResponse"/></returns>
        public Task<TextWritingResponse> TextWriting(TextWritingRequest req)
        {
            return InternalRequestAsync<TextWritingResponse>(req, "TextWriting");
        }

        /// <summary>
        /// 通过自动补全文本片段，帮助用户快速生成高质量、连贯的完整文本，提高创作效率。
        /// </summary>
        /// <param name="req"><see cref="TextWritingRequest"/></param>
        /// <returns><see cref="TextWritingResponse"/></returns>
        public TextWritingResponse TextWritingSync(TextWritingRequest req)
        {
            return InternalRequestAsync<TextWritingResponse>(req, "TextWriting")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
