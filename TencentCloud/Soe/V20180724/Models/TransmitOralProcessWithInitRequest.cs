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

namespace TencentCloud.Soe.V20180724.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TransmitOralProcessWithInitRequest : AbstractModel
    {
        
        /// <summary>
        /// 流式数据包的序号，从1开始，当IsEnd字段为1后后续序号无意义，当IsLongLifeSession不为1且为非流式模式时无意义。
        /// </summary>
        [JsonProperty("SeqId")]
        public long? SeqId{ get; set; }

        /// <summary>
        /// 是否传输完毕标志，若为0表示未完毕，若为1则传输完毕开始评估，非流式模式下无意义。
        /// </summary>
        [JsonProperty("IsEnd")]
        public long? IsEnd{ get; set; }

        /// <summary>
        /// 语音文件类型 	1: raw, 2: wav, 3: mp3, 4: speex (语言文件格式目前仅支持 16k 采样率 16bit 编码单声道，如有不一致可能导致评估不准确或失败)。
        /// </summary>
        [JsonProperty("VoiceFileType")]
        public long? VoiceFileType{ get; set; }

        /// <summary>
        /// 语音编码类型	1:pcm。
        /// </summary>
        [JsonProperty("VoiceEncodeType")]
        public long? VoiceEncodeType{ get; set; }

        /// <summary>
        /// 当前数据包数据, 流式模式下数据包大小可以按需设置，在网络良好的情况下，建议设置为0.5k，且必须保证分片帧完整（16bit的数据必须保证音频长度为偶数），编码格式要求为BASE64。
        /// </summary>
        [JsonProperty("UserVoiceData")]
        public string UserVoiceData{ get; set; }

        /// <summary>
        /// 语音段唯一标识，一个完整语音一个SessionId。
        /// </summary>
        [JsonProperty("SessionId")]
        public string SessionId{ get; set; }

        /// <summary>
        /// 被评估语音对应的文本，句子模式下不超过个 20 单词或者中文文字，段落模式不超过 120 单词或者中文文字，中文评估使用 utf-8 编码，自由说模式该值无效。如需要在单词模式和句子模式下使用自定义音素，可以通过设置 TextMode 使用[音素标注](https://cloud.tencent.com/document/product/884/33698)。
        /// </summary>
        [JsonProperty("RefText")]
        public string RefText{ get; set; }

        /// <summary>
        /// 语音输入模式，0：流式分片，1：非流式一次性评估
        /// </summary>
        [JsonProperty("WorkMode")]
        public long? WorkMode{ get; set; }

        /// <summary>
        /// 评估模式，0：词模式（中文评测模式下为文字模式），1：句子模式，2：段落模式，3：自由说模式，当为词模式评估时，能够提供每个音节的评估信息，当为句子模式时，能够提供完整度和流利度信息，4：单词纠错模式：能够对单词和句子中的读错读音进行纠正，给出参考正确读音。
        /// </summary>
        [JsonProperty("EvalMode")]
        public long? EvalMode{ get; set; }

        /// <summary>
        /// 评价苛刻指数，取值为[1.0 - 4.0]范围内的浮点数，用于平滑不同年龄段的分数，1.0为小年龄段，4.0为最高年龄段
        /// </summary>
        [JsonProperty("ScoreCoeff")]
        public float? ScoreCoeff{ get; set; }

        /// <summary>
        /// 业务应用ID，与账号应用APPID无关，是用来方便客户管理服务的参数，新的 SoeAppId 可以在[控制台](https://console.cloud.tencent.com/soe)【应用管理】下新建。
        /// </summary>
        [JsonProperty("SoeAppId")]
        public string SoeAppId{ get; set; }

        /// <summary>
        /// 音频存储模式，0：不存储，1：存储到公共对象存储，输出结果为该会话最后一个分片TransmitOralProcess 返回结果 AudioUrl 字段，2：永久存储音频，需要提工单申请，会产生一定存储费用，3：自定义存储，将音频存储到自定义的腾讯云[对象存储](https://cloud.tencent.com/product/cos)中，需要提工单登记存储信息。
        /// </summary>
        [JsonProperty("StorageMode")]
        public long? StorageMode{ get; set; }

        /// <summary>
        /// 输出断句中间结果标识，0：不输出，1：输出，通过设置该参数，可以在评估过程中的分片传输请求中，返回已经评估断句的中间结果，中间结果可用于客户端 UI 更新，输出结果为TransmitOralProcess请求返回结果 SentenceInfoSet 字段。
        /// </summary>
        [JsonProperty("SentenceInfoEnabled")]
        public long? SentenceInfoEnabled{ get; set; }

        /// <summary>
        /// 评估语言，0：英文，1：中文。
        /// </summary>
        [JsonProperty("ServerType")]
        public long? ServerType{ get; set; }

        /// <summary>
        /// 异步模式标识，0：同步模式，1：异步模式，可选值参考[服务模式](https://cloud.tencent.com/document/product/884/33697)。
        /// </summary>
        [JsonProperty("IsAsync")]
        public long? IsAsync{ get; set; }

        /// <summary>
        /// 查询标识，当该参数为1时，该请求为查询请求，请求返回该 Session 评估结果。
        /// </summary>
        [JsonProperty("IsQuery")]
        public long? IsQuery{ get; set; }

        /// <summary>
        /// 输入文本模式，0: 普通文本，1：[音素结构](https://cloud.tencent.com/document/product/884/33698)文本。2：音素注册模式（提工单注册需要使用音素的单词）。
        /// </summary>
        [JsonProperty("TextMode")]
        public long? TextMode{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SeqId", this.SeqId);
            this.SetParamSimple(map, prefix + "IsEnd", this.IsEnd);
            this.SetParamSimple(map, prefix + "VoiceFileType", this.VoiceFileType);
            this.SetParamSimple(map, prefix + "VoiceEncodeType", this.VoiceEncodeType);
            this.SetParamSimple(map, prefix + "UserVoiceData", this.UserVoiceData);
            this.SetParamSimple(map, prefix + "SessionId", this.SessionId);
            this.SetParamSimple(map, prefix + "RefText", this.RefText);
            this.SetParamSimple(map, prefix + "WorkMode", this.WorkMode);
            this.SetParamSimple(map, prefix + "EvalMode", this.EvalMode);
            this.SetParamSimple(map, prefix + "ScoreCoeff", this.ScoreCoeff);
            this.SetParamSimple(map, prefix + "SoeAppId", this.SoeAppId);
            this.SetParamSimple(map, prefix + "StorageMode", this.StorageMode);
            this.SetParamSimple(map, prefix + "SentenceInfoEnabled", this.SentenceInfoEnabled);
            this.SetParamSimple(map, prefix + "ServerType", this.ServerType);
            this.SetParamSimple(map, prefix + "IsAsync", this.IsAsync);
            this.SetParamSimple(map, prefix + "IsQuery", this.IsQuery);
            this.SetParamSimple(map, prefix + "TextMode", this.TextMode);
        }
    }
}

