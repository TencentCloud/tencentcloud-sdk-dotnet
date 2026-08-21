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

namespace TencentCloud.Csip.V20221121.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class WebhookAssetScope : AbstractModel
    {
        
        /// <summary>
        /// 资产范围类型（对齐 NotifyAssetRange）
        /// 枚举值：
        /// 1：全部主机（可剔除）
        /// 2：自选主机
        /// 3：按标签选择
        /// </summary>
        [JsonProperty("AssetRange")]
        public long? AssetRange{ get; set; }

        /// <summary>
        /// 选中的主机 quuid 列表，仅 AssetRange=2 生效
        /// </summary>
        [JsonProperty("InstanceIds")]
        public string[] InstanceIds{ get; set; }

        /// <summary>
        /// 排除的主机 quuid 列表，仅 AssetRange=1 生效
        /// </summary>
        [JsonProperty("ExcludedInstanceIds")]
        public string[] ExcludedInstanceIds{ get; set; }

        /// <summary>
        /// 安全中心标签 ID 列表，仅 AssetRange=3 生效
        /// </summary>
        [JsonProperty("TagIds")]
        public long?[] TagIds{ get; set; }

        /// <summary>
        /// 腾讯云标签列表，仅 AssetRange=3 生效
        /// 入参限制：AssetRange=3 时 TagIds + CloudTags 不能同时为空
        /// </summary>
        [JsonProperty("CloudTags")]
        public string[] CloudTags{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AssetRange", this.AssetRange);
            this.SetParamArraySimple(map, prefix + "InstanceIds.", this.InstanceIds);
            this.SetParamArraySimple(map, prefix + "ExcludedInstanceIds.", this.ExcludedInstanceIds);
            this.SetParamArraySimple(map, prefix + "TagIds.", this.TagIds);
            this.SetParamArraySimple(map, prefix + "CloudTags.", this.CloudTags);
        }
    }
}

