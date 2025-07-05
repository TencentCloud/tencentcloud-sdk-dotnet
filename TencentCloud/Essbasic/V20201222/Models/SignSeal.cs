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

    public class SignSeal : AbstractModel
    {
        
        /// <summary>
        /// 签署控件ID
        /// </summary>
        [JsonProperty("ComponentId")]
        public string ComponentId{ get; set; }

        /// <summary>
        /// 签署印章类型:
        /// SIGN_SIGNATURE - 签名
        /// SIGN_SEAL - 印章
        /// SIGN_DATE - 日期
        /// SIGN_IMAGE - 图片
        /// </summary>
        [JsonProperty("SignType")]
        public string SignType{ get; set; }

        /// <summary>
        /// 合同文件ID
        /// </summary>
        [JsonProperty("FileIndex")]
        public long? FileIndex{ get; set; }

        /// <summary>
        /// 印章ID，仅当 SignType 为 SIGN_SEAL 时必填
        /// </summary>
        [JsonProperty("SealId")]
        public string SealId{ get; set; }

        /// <summary>
        /// 签名内容，仅当 SignType 为SIGN_SIGNATURE或SIGN_IMAGE 时必填，base64编码
        /// </summary>
        [JsonProperty("SealContent")]
        public string SealContent{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ComponentId", this.ComponentId);
            this.SetParamSimple(map, prefix + "SignType", this.SignType);
            this.SetParamSimple(map, prefix + "FileIndex", this.FileIndex);
            this.SetParamSimple(map, prefix + "SealId", this.SealId);
            this.SetParamSimple(map, prefix + "SealContent", this.SealContent);
        }
    }
}

