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

namespace TencentCloud.Essbasic.V20201222.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CheckFaceIdentifyResponse : AbstractModel
    {
        
        /// <summary>
        /// 核身结果; 0:通过,1:不通过
        /// </summary>
        [JsonProperty("Result")]
        public long? Result{ get; set; }

        /// <summary>
        /// 核身结果描述
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 渠道名
        /// </summary>
        [JsonProperty("ChannelName")]
        public string ChannelName{ get; set; }

        /// <summary>
        /// 认证通过时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("VerifiedOn")]
        public long? VerifiedOn{ get; set; }

        /// <summary>
        /// 核身流水号
        /// </summary>
        [JsonProperty("SerialNumber")]
        public string SerialNumber{ get; set; }

        /// <summary>
        /// 渠道核身服务器IP
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("VerifyServerIp")]
        public string VerifyServerIp{ get; set; }

        /// <summary>
        /// 核身照片文件名
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PhotoFileName")]
        public string PhotoFileName{ get; set; }

        /// <summary>
        /// 核身照片内容base64(文件格式见文件名后缀,一般为jpg)
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PhotoFileData")]
        public string PhotoFileData{ get; set; }

        /// <summary>
        /// 唯一请求 ID，每次请求都会返回。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Result", this.Result);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "ChannelName", this.ChannelName);
            this.SetParamSimple(map, prefix + "VerifiedOn", this.VerifiedOn);
            this.SetParamSimple(map, prefix + "SerialNumber", this.SerialNumber);
            this.SetParamSimple(map, prefix + "VerifyServerIp", this.VerifyServerIp);
            this.SetParamSimple(map, prefix + "PhotoFileName", this.PhotoFileName);
            this.SetParamSimple(map, prefix + "PhotoFileData", this.PhotoFileData);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

