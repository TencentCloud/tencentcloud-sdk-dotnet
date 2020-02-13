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

namespace TencentCloud.Cdn.V20180606.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AuthenticationTypeA : AbstractModel
    {
        
        /// <summary>
        /// 计算签名的密钥
        /// 仅允许大小写字母与数字，长度 6~32 位
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SecretKey")]
        public string SecretKey{ get; set; }

        /// <summary>
        /// 签名参数名设置
        /// 仅允许大小写字母、数字或下划线，长度 1~100 位，不能以数字开头
        /// </summary>
        [JsonProperty("SignParam")]
        public string SignParam{ get; set; }

        /// <summary>
        /// 签名过期时间设置
        /// 单位为秒，最大可设置为 31536000
        /// </summary>
        [JsonProperty("ExpireTime")]
        public long? ExpireTime{ get; set; }

        /// <summary>
        /// 鉴权/不做鉴权的文件扩展名列表设置
        /// 如果包含字符 *  则表示所有文件
        /// </summary>
        [JsonProperty("FileExtensions")]
        public string[] FileExtensions{ get; set; }

        /// <summary>
        /// whitelist：白名单，表示对除了 FileExtensions 列表之外的所有类型进行鉴权
        /// blacklist：黑名单，表示仅对 FileExtensions 中的类型进行鉴权
        /// </summary>
        [JsonProperty("FilterType")]
        public string FilterType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SecretKey", this.SecretKey);
            this.SetParamSimple(map, prefix + "SignParam", this.SignParam);
            this.SetParamSimple(map, prefix + "ExpireTime", this.ExpireTime);
            this.SetParamArraySimple(map, prefix + "FileExtensions.", this.FileExtensions);
            this.SetParamSimple(map, prefix + "FilterType", this.FilterType);
        }
    }
}

