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

namespace TencentCloud.Dts.V20211206.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateMigrationServiceRequest : AbstractModel
    {
        
        /// <summary>
        /// 源实例数据库类型，如mysql,redis,percona,mongodb,postgresql,sqlserver,mariadb,cynosdbmysql
        /// </summary>
        [JsonProperty("SrcDatabaseType")]
        public string SrcDatabaseType{ get; set; }

        /// <summary>
        /// 目标实例数据库类型，如mysql,redis,percona,mongodb,postgresql,sqlserver,mariadb,cynosdbmysql
        /// </summary>
        [JsonProperty("DstDatabaseType")]
        public string DstDatabaseType{ get; set; }

        /// <summary>
        /// 源实例地域，如：ap-guangzhou
        /// </summary>
        [JsonProperty("SrcRegion")]
        public string SrcRegion{ get; set; }

        /// <summary>
        /// 目标实例地域，如：ap-guangzhou。注意，目标地域必须和API请求地域保持一致。
        /// </summary>
        [JsonProperty("DstRegion")]
        public string DstRegion{ get; set; }

        /// <summary>
        /// 实例规格，包括：small、medium、large、xlarge、2xlarge
        /// </summary>
        [JsonProperty("InstanceClass")]
        public string InstanceClass{ get; set; }

        /// <summary>
        /// 购买数量，范围为[1,15]，默认为1
        /// </summary>
        [JsonProperty("Count")]
        public ulong? Count{ get; set; }

        /// <summary>
        /// 迁移服务名称，最大长度128
        /// </summary>
        [JsonProperty("JobName")]
        public string JobName{ get; set; }

        /// <summary>
        /// 标签信息
        /// </summary>
        [JsonProperty("Tags")]
        public TagItem[] Tags{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SrcDatabaseType", this.SrcDatabaseType);
            this.SetParamSimple(map, prefix + "DstDatabaseType", this.DstDatabaseType);
            this.SetParamSimple(map, prefix + "SrcRegion", this.SrcRegion);
            this.SetParamSimple(map, prefix + "DstRegion", this.DstRegion);
            this.SetParamSimple(map, prefix + "InstanceClass", this.InstanceClass);
            this.SetParamSimple(map, prefix + "Count", this.Count);
            this.SetParamSimple(map, prefix + "JobName", this.JobName);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
        }
    }
}

