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

    public class CreateDSPAMetaResourcesRequest : AbstractModel
    {
        
        /// <summary>
        /// 资源类型，支持：cdb（云数据库 MySQL）、dcdb（TDSQL MySQL版）、mariadb（云数据库 MariaDB）、postgres（云数据库 PostgreSQL）、cynosdbpg（TDSQL-C PostgreSQL版）、cynosdbmysql（TDSQL-C MySQL版）
        /// </summary>
        [JsonProperty("MetaType")]
        public string MetaType{ get; set; }

        /// <summary>
        /// 资源所处地域。
        /// </summary>
        [JsonProperty("ResourceRegion")]
        public string ResourceRegion{ get; set; }

        /// <summary>
        /// DSPA实例ID。
        /// </summary>
        [JsonProperty("DspaId")]
        public string DspaId{ get; set; }

        /// <summary>
        /// 用来标记本次更新是否已经是最后一次，可选值：continue（后续还需要更新）、finished（本次是最后一次更新）。
        /// </summary>
        [JsonProperty("UpdateStatus")]
        public string UpdateStatus{ get; set; }

        /// <summary>
        /// 本次更新的ID号，用来标记一次完整的更新过程。
        /// </summary>
        [JsonProperty("UpdateId")]
        public string UpdateId{ get; set; }

        /// <summary>
        /// 资源列表。
        /// </summary>
        [JsonProperty("Items")]
        public DspaUserResourceMeta[] Items{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MetaType", this.MetaType);
            this.SetParamSimple(map, prefix + "ResourceRegion", this.ResourceRegion);
            this.SetParamSimple(map, prefix + "DspaId", this.DspaId);
            this.SetParamSimple(map, prefix + "UpdateStatus", this.UpdateStatus);
            this.SetParamSimple(map, prefix + "UpdateId", this.UpdateId);
            this.SetParamArrayObj(map, prefix + "Items.", this.Items);
        }
    }
}

