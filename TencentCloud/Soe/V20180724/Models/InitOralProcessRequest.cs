/*
 * Copyright (c) 2018-2025 Tencent. All Rights Reserved.
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

namespace TencentCloud.Soe.V20180724.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class InitOralProcessRequest : AbstractModel
    {
        
        /// <summary>
        /// 语音段唯一标识，一段完整语音使用一个SessionId，不同语音段的评测需要使用不同的SessionId。一般使用uuid(通用唯一识别码)来作为它的值，要尽量保证SessionId的唯一性。
        /// </summary>
        [JsonProperty("SessionId")]
        public string SessionId{ get; set; }

        /// <summary>
        /// 被评估语音对应的文本，仅支持中文和英文。
        /// 句子模式下不超过个 30 单词或者中文文字，段落模式不超过 120 单词或者中文文字，中文评估使用 utf-8 编码，自由说模式RefText可以不填。
        /// 关于RefText的文本键入要求，请参考[评测模式介绍](https://cloud.tencent.com/document/product/884/56131)。
        /// 如需要在评测模式下使用自定义注音（支持中英文），可以通过设置「TextMode」参数实现，设置方式请参考[音素标注](https://cloud.tencent.com/document/product/884/33698)。
        /// </summary>
        [JsonProperty("RefText")]
        public string RefText{ get; set; }

        /// <summary>
        /// 语音输入模式
        /// 0：流式分片
        /// 1：非流式一次性评估
        /// 推荐使用流式分片传输。
        /// </summary>
        [JsonProperty("WorkMode")]
        public long? WorkMode{ get; set; }

        /// <summary>
        /// 评测模式
        /// 0：单词/单字模式（中文评测模式下为单字模式）
        /// 1：句子模式
        /// 2：段落模式
        /// 3：自由说模式
        /// 4：单词音素纠错模式
        /// 5：情景评测模式
        /// 6：句子多分支评测模式
        /// 7：单词实时评测模式
        /// 8：拼音评测模式
        /// 关于每种评测模式的详细介绍，以及适用场景，请参考[评测模式介绍](https://cloud.tencent.com/document/product/884/56131)。
        /// </summary>
        [JsonProperty("EvalMode")]
        public long? EvalMode{ get; set; }

        /// <summary>
        /// 评价苛刻指数。取值为[1.0 - 4.0]范围内的浮点数，用于平滑不同年龄段的分数。
        /// 1.0：适用于最小年龄段用户，一般对应儿童应用场景；
        /// 4.0：适用于最高年龄段用户，一般对应成人严格打分场景。苛刻度影响范围参考：[苛刻度影响范围](https://cloud.tencent.com/document/product/884/78824#.E8.8B.9B.E5.88.BB.E5.BA.A6)
        /// </summary>
        [JsonProperty("ScoreCoeff")]
        public float? ScoreCoeff{ get; set; }

        /// <summary>
        /// 业务应用ID，与账号应用APPID无关，是用来方便客户管理服务的参数，新的 SoeAppId 可以在[控制台](https://console.cloud.tencent.com/soe)【应用管理】下新建。如果没有新建SoeAppId，请勿填入该参数，否则会报欠费错误。使用指南：[业务应用](https://cloud.tencent.com/document/product/884/78824#.E4.B8.9A.E5.8A.A1.E5.BA.94.E7.94.A8)
        /// </summary>
        [JsonProperty("SoeAppId")]
        public string SoeAppId{ get; set; }

        /// <summary>
        /// 长效session标识，当该参数为1时，session的持续时间为300s，但会一定程度上影响第一个数据包的返回速度，且TransmitOralProcess必须同时为1才可生效。
        /// </summary>
        [JsonProperty("IsLongLifeSession")]
        public long? IsLongLifeSession{ get; set; }

        /// <summary>
        /// 音频存储模式，此参数已废弃，无需设置，设置与否都默认为0不存储；
        /// 注：有存储需求的用户建议自行存储至腾讯云COS[对象存储](https://cloud.tencent.com/product/cos)使用。
        /// </summary>
        [JsonProperty("StorageMode")]
        public long? StorageMode{ get; set; }

        /// <summary>
        /// 输出断句中间结果标识
        /// 0：不输出
        /// 1：输出，通过设置该参数
        /// 可以在评估过程中的分片传输请求中，返回已经评估断句的中间结果，中间结果可用于客户端 UI 更新，输出结果为TransmitOralProcess请求返回结果 SentenceInfoSet 字段。
        /// </summary>
        [JsonProperty("SentenceInfoEnabled")]
        public long? SentenceInfoEnabled{ get; set; }

        /// <summary>
        /// 评估语言
        /// 0：英文（默认）
        /// 1：中文
        /// </summary>
        [JsonProperty("ServerType")]
        public long? ServerType{ get; set; }

        /// <summary>
        /// 异步模式标识
        /// 0：同步模式
        /// 1：异步模式（一般情况不建议使用异步模式）
        /// 可选值参考[服务模式](https://cloud.tencent.com/document/product/884/33697)。
        /// </summary>
        [JsonProperty("IsAsync")]
        public long? IsAsync{ get; set; }

        /// <summary>
        /// 输入文本模式
        /// 0: 普通文本
        /// 1：[音素结构](https://cloud.tencent.com/document/product/884/33698)文本
        /// </summary>
        [JsonProperty("TextMode")]
        public long? TextMode{ get; set; }

        /// <summary>
        /// 主题词和关键词
        /// </summary>
        [JsonProperty("Keyword")]
        public string Keyword{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SessionId", this.SessionId);
            this.SetParamSimple(map, prefix + "RefText", this.RefText);
            this.SetParamSimple(map, prefix + "WorkMode", this.WorkMode);
            this.SetParamSimple(map, prefix + "EvalMode", this.EvalMode);
            this.SetParamSimple(map, prefix + "ScoreCoeff", this.ScoreCoeff);
            this.SetParamSimple(map, prefix + "SoeAppId", this.SoeAppId);
            this.SetParamSimple(map, prefix + "IsLongLifeSession", this.IsLongLifeSession);
            this.SetParamSimple(map, prefix + "StorageMode", this.StorageMode);
            this.SetParamSimple(map, prefix + "SentenceInfoEnabled", this.SentenceInfoEnabled);
            this.SetParamSimple(map, prefix + "ServerType", this.ServerType);
            this.SetParamSimple(map, prefix + "IsAsync", this.IsAsync);
            this.SetParamSimple(map, prefix + "TextMode", this.TextMode);
            this.SetParamSimple(map, prefix + "Keyword", this.Keyword);
        }
    }
}

