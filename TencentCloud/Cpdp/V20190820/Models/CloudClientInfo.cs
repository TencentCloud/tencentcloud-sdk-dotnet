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

namespace TencentCloud.Cpdp.V20190820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CloudClientInfo : AbstractModel
    {
        
        /// <summary>
        /// 场景类型。
        /// wechat_ecommerce渠道 - h5支付方式，此字段必填；
        /// 枚举值：
        /// CLIENT_TYPE_UNKNOWN 未知;
        /// CLIENT_TYPE_IOS ios系统;
        /// CLIENT_TYPE_ANDROID 安卓系统;
        /// CLIENT_TYPE_WAP WAP场景;
        /// CLIENT_TYPE_H5 H5场景;
        /// </summary>
        [JsonProperty("ClientType")]
        public string ClientType{ get; set; }

        /// <summary>
        /// 应用名称。
        /// </summary>
        [JsonProperty("AppName")]
        public string AppName{ get; set; }

        /// <summary>
        /// 网站URL。
        /// </summary>
        [JsonProperty("AppUrl")]
        public string AppUrl{ get; set; }

        /// <summary>
        /// IOS平台BundleID。
        /// </summary>
        [JsonProperty("BundleId")]
        public string BundleId{ get; set; }

        /// <summary>
        /// Android平台PackageName
        /// </summary>
        [JsonProperty("PackageName")]
        public string PackageName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ClientType", this.ClientType);
            this.SetParamSimple(map, prefix + "AppName", this.AppName);
            this.SetParamSimple(map, prefix + "AppUrl", this.AppUrl);
            this.SetParamSimple(map, prefix + "BundleId", this.BundleId);
            this.SetParamSimple(map, prefix + "PackageName", this.PackageName);
        }
    }
}

