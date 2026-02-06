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
       private const string sdkVersion = "SDK_NET_3.0.1375";

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
