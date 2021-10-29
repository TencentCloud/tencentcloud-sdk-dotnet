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

namespace TencentCloud.Taf.V20200210.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class InputSendTrafficSecuritySmsMsg : AbstractModel
    {
        
        /// <summary>
        /// 投放任务ID
        /// </summary>
        [JsonProperty("TaskId")]
        public string TaskId{ get; set; }

        /// <summary>
        /// 手机号码列表（号码量<=200）
        /// </summary>
        [JsonProperty("Mobiles")]
        public string[] Mobiles{ get; set; }

        /// <summary>
        /// 是否授权，1：已授权
        /// </summary>
        [JsonProperty("IsAuthorized")]
        public long? IsAuthorized{ get; set; }

        /// <summary>
        /// 加密方式，0：AES加密；1：DES加密
        /// </summary>
        [JsonProperty("EncryptMethod")]
        public long? EncryptMethod{ get; set; }

        /// <summary>
        /// 加密算法中的块处理模式，0：ECB模式；1：CBC模式；2：CTR模式；3：CFB模式；4：OFB模式；
        /// </summary>
        [JsonProperty("EncryptMode")]
        public long? EncryptMode{ get; set; }

        /// <summary>
        /// 填充模式，0：ZeroPadding；1：PKCS5Padding；2：PKCS7Padding；
        /// </summary>
        [JsonProperty("PaddingType")]
        public long? PaddingType{ get; set; }

        /// <summary>
        /// 加密数据
        /// </summary>
        [JsonProperty("EncryptData")]
        public string EncryptData{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamArraySimple(map, prefix + "Mobiles.", this.Mobiles);
            this.SetParamSimple(map, prefix + "IsAuthorized", this.IsAuthorized);
            this.SetParamSimple(map, prefix + "EncryptMethod", this.EncryptMethod);
            this.SetParamSimple(map, prefix + "EncryptMode", this.EncryptMode);
            this.SetParamSimple(map, prefix + "PaddingType", this.PaddingType);
            this.SetParamSimple(map, prefix + "EncryptData", this.EncryptData);
        }
    }
}

