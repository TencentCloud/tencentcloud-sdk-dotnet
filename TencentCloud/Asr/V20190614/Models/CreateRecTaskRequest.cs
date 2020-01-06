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

namespace TencentCloud.Asr.V20190614.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateRecTaskRequest : AbstractModel
    {
        
        /// <summary>
        /// 引擎模型类型。
        /// 8k_0：电话 8k 中文普通话通用，可用于双声道音频的识别；
        /// 8k_6：电话 8k 中文普通话话者分离，仅用于单声道；
        /// 16k_0：16k 中文普通话通用；
        /// 16k_en：16k 英语；
        /// 16k_ca：16k 粤语。
        /// </summary>
        [JsonProperty("EngineModelType")]
        public string EngineModelType{ get; set; }

        /// <summary>
        /// 语音声道数。1：单声道；2：双声道（仅在电话 8k 通用模型下支持）。
        /// </summary>
        [JsonProperty("ChannelNum")]
        public ulong? ChannelNum{ get; set; }

        /// <summary>
        /// 识别结果文本编码方式。0：UTF-8。
        /// </summary>
        [JsonProperty("ResTextFormat")]
        public ulong? ResTextFormat{ get; set; }

        /// <summary>
        /// 语音数据来源。0：语音 URL；1：语音数据（post body）。
        /// </summary>
        [JsonProperty("SourceType")]
        public ulong? SourceType{ get; set; }

        /// <summary>
        /// 回调 URL，用户自行搭建的用于接收识别结果的服务器地址， 长度小于2048字节。如果用户使用回调方式获取识别结果，需提交该参数；如果用户使用轮询方式获取识别结果，则无需提交该参数。
        /// </summary>
        [JsonProperty("CallbackUrl")]
        public string CallbackUrl{ get; set; }

        /// <summary>
        /// 语音的URL地址，需要公网可下载。长度小于2048字节，当 SourceType 值为 0 时须填写该字段，为 1 时不需要填写。注意：请确保录音文件时长在一个小时之内，否则可能识别失败。请保证文件的下载速度，否则可能下载失败。
        /// </summary>
        [JsonProperty("Url")]
        public string Url{ get; set; }

        /// <summary>
        /// 语音数据，当SourceType 值为1时必须填写，为0可不写。要base64编码(采用python语言时注意读取文件应该为string而不是byte，以byte格式读取后要decode()。编码后的数据不可带有回车换行符)。音频数据要小于5MB。
        /// </summary>
        [JsonProperty("Data")]
        public string Data{ get; set; }

        /// <summary>
        /// 数据长度，当 SourceType 值为1时必须填写，为0可不写（此数据长度为数据未进行base64编码时的数据长度）。
        /// </summary>
        [JsonProperty("DataLen")]
        public ulong? DataLen{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EngineModelType", this.EngineModelType);
            this.SetParamSimple(map, prefix + "ChannelNum", this.ChannelNum);
            this.SetParamSimple(map, prefix + "ResTextFormat", this.ResTextFormat);
            this.SetParamSimple(map, prefix + "SourceType", this.SourceType);
            this.SetParamSimple(map, prefix + "CallbackUrl", this.CallbackUrl);
            this.SetParamSimple(map, prefix + "Url", this.Url);
            this.SetParamSimple(map, prefix + "Data", this.Data);
            this.SetParamSimple(map, prefix + "DataLen", this.DataLen);
        }
    }
}

