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

namespace TencentCloud.Tcb.V20180608.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class BaasPackageInfo : AbstractModel
    {
        
        /// <summary>
        /// DAU产品套餐ID
        /// </summary>
        [JsonProperty("PackageName")]
        public string PackageName{ get; set; }

        /// <summary>
        /// DAU套餐中文名称
        /// </summary>
        [JsonProperty("PackageTitle")]
        public string PackageTitle{ get; set; }

        /// <summary>
        /// 套餐分组
        /// </summary>
        [JsonProperty("GroupName")]
        public string GroupName{ get; set; }

        /// <summary>
        /// 套餐分组中文名
        /// </summary>
        [JsonProperty("GroupTitle")]
        public string GroupTitle{ get; set; }

        /// <summary>
        /// json格式化计费标签，例如：
        /// {"pid":2, "cids":{"create": 2, "renew": 2, "modify": 2}, "productCode":"p_tcb_mp", "subProductCode":"sp_tcb_mp_cloudbase_dau"}
        /// </summary>
        [JsonProperty("BillTags")]
        public string BillTags{ get; set; }

        /// <summary>
        /// json格式化用户资源限制，例如：
        /// {"Qps":1000,"InvokeNum":{"TimeUnit":"m", "Unit":"万次", "MaxSize": 100},"Capacity":{"TimeUnit":"m", "Unit":"GB", "MaxSize": 100}, "Cdn":{"Flux":{"TimeUnit":"m", "Unit":"GB", "MaxSize": 100}, "BackFlux":{"TimeUnit":"m", "Unit":"GB", "MaxSize": 100}},"Scf":{"Concurrency":1000,"OutFlux":{"TimeUnit":"m", "Unit":"GB", "MaxSize": 100},"MemoryUse":{"TimeUnit":"m", "Unit":"WGBS", "MaxSize": 100000}}}
        /// </summary>
        [JsonProperty("ResourceLimit")]
        public string ResourceLimit{ get; set; }

        /// <summary>
        /// json格式化高级限制，例如：
        /// {"CMSEnable":false,"ProvisionedConcurrencyMem":512000, "PictureProcessing":false, "SecurityAudit":false, "RealTimePush":false, "TemplateMessageBatchPush":false, "Payment":false}
        /// </summary>
        [JsonProperty("AdvanceLimit")]
        public string AdvanceLimit{ get; set; }

        /// <summary>
        /// 套餐描述
        /// </summary>
        [JsonProperty("PackageDescription")]
        public string PackageDescription{ get; set; }

        /// <summary>
        /// 是否对外展示
        /// </summary>
        [JsonProperty("IsExternal")]
        public bool? IsExternal{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PackageName", this.PackageName);
            this.SetParamSimple(map, prefix + "PackageTitle", this.PackageTitle);
            this.SetParamSimple(map, prefix + "GroupName", this.GroupName);
            this.SetParamSimple(map, prefix + "GroupTitle", this.GroupTitle);
            this.SetParamSimple(map, prefix + "BillTags", this.BillTags);
            this.SetParamSimple(map, prefix + "ResourceLimit", this.ResourceLimit);
            this.SetParamSimple(map, prefix + "AdvanceLimit", this.AdvanceLimit);
            this.SetParamSimple(map, prefix + "PackageDescription", this.PackageDescription);
            this.SetParamSimple(map, prefix + "IsExternal", this.IsExternal);
        }
    }
}

