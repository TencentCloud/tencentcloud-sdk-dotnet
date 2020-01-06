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

    public class KeywordEvaluateRequest : AbstractModel
    {
        
        /// <summary>
        /// 流式数据包的序号，从1开始，当IsEnd字段为1后后续序号无意义，当IsLongLifeSession不为1且为非流式模式时无意义。
        /// </summary>
        [JsonProperty("SeqId")]
        public ulong? SeqId{ get; set; }

        /// <summary>
        /// 是否传输完毕标志，若为0表示未完毕，若为1则传输完毕开始评估，非流式模式下无意义。
        /// </summary>
        [JsonProperty("IsEnd")]
        public ulong? IsEnd{ get; set; }

        /// <summary>
        /// 语音文件类型 	1: raw, 2: wav, 3: mp3, 4: speex (语言文件格式目前仅支持 16k 采样率 16bit 编码单声道，如有不一致可能导致评估不准确或失败)。
        /// </summary>
        [JsonProperty("VoiceFileType")]
        public ulong? VoiceFileType{ get; set; }

        /// <summary>
        /// 语音编码类型	1:pcm。
        /// </summary>
        [JsonProperty("VoiceEncodeType")]
        public ulong? VoiceEncodeType{ get; set; }

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
        /// 关键词列表
        /// </summary>
        [JsonProperty("Keywords")]
        public Keyword[] Keywords{ get; set; }

        /// <summary>
        /// 业务应用ID，与账号应用APPID无关，是用来方便客户管理服务的参数，新的 SoeAppId 可以在[控制台](https://console.cloud.tencent.com/soe)【应用管理】下新建。
        /// </summary>
        [JsonProperty("SoeAppId")]
        public string SoeAppId{ get; set; }

        /// <summary>
        /// 查询标识，当该参数为1时，该请求为查询请求，请求返回该 Session 评估结果。
        /// </summary>
        [JsonProperty("IsQuery")]
        public ulong? IsQuery{ get; set; }


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
            this.SetParamArrayObj(map, prefix + "Keywords.", this.Keywords);
            this.SetParamSimple(map, prefix + "SoeAppId", this.SoeAppId);
            this.SetParamSimple(map, prefix + "IsQuery", this.IsQuery);
        }
    }
}

