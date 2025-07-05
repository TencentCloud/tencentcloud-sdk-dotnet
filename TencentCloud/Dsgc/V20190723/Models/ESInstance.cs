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

namespace TencentCloud.Dsgc.V20190723.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ESInstance : AbstractModel
    {
        
        /// <summary>
        /// 数据源id
        /// </summary>
        [JsonProperty("DataSourceId")]
        public string DataSourceId{ get; set; }

        /// <summary>
        /// 数据源类型
        /// </summary>
        [JsonProperty("DataSourceType")]
        public string DataSourceType{ get; set; }

        /// <summary>
        /// 地域
        /// </summary>
        [JsonProperty("ResourceRegion")]
        public string ResourceRegion{ get; set; }

        /// <summary>
        /// 扫描任务ID
        /// </summary>
        [JsonProperty("DiscoveryTaskId")]
        public long? DiscoveryTaskId{ get; set; }

        /// <summary>
        /// 扫描任务实例ID
        /// </summary>
        [JsonProperty("DiscoveryTaskInstanceID")]
        public long? DiscoveryTaskInstanceID{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DataSourceId", this.DataSourceId);
            this.SetParamSimple(map, prefix + "DataSourceType", this.DataSourceType);
            this.SetParamSimple(map, prefix + "ResourceRegion", this.ResourceRegion);
            this.SetParamSimple(map, prefix + "DiscoveryTaskId", this.DiscoveryTaskId);
            this.SetParamSimple(map, prefix + "DiscoveryTaskInstanceID", this.DiscoveryTaskInstanceID);
        }
    }
}

