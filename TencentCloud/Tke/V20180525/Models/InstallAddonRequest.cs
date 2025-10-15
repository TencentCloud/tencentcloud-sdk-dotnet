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

namespace TencentCloud.Tke.V20180525.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class InstallAddonRequest : AbstractModel
    {
        
        /// <summary>
        /// 集群ID（仅支持标准tke集群），请从容器服务控制台集群列表中获取（https://console.cloud.tencent.com/tke2/cluster）。
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// addon名称，请从容器服务控制台进入集群详情页后，在组件管理页面中获取。
        /// </summary>
        [JsonProperty("AddonName")]
        public string AddonName{ get; set; }

        /// <summary>
        /// addon版本（不传默认安装最新版本）
        /// </summary>
        [JsonProperty("AddonVersion")]
        public string AddonVersion{ get; set; }

        /// <summary>
        /// addon的参数，是一个json格式的base64转码后的字符串（addon参数由DescribeAddonValues获取）
        /// </summary>
        [JsonProperty("RawValues")]
        public string RawValues{ get; set; }

        /// <summary>
        /// 是否仅做安装检查，设置为true时仅做检查，不会安装组件。默认值为 false。
        /// </summary>
        [JsonProperty("DryRun")]
        public bool? DryRun{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamSimple(map, prefix + "AddonName", this.AddonName);
            this.SetParamSimple(map, prefix + "AddonVersion", this.AddonVersion);
            this.SetParamSimple(map, prefix + "RawValues", this.RawValues);
            this.SetParamSimple(map, prefix + "DryRun", this.DryRun);
        }
    }
}

