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

namespace TencentCloud.Dlc.V20210125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ConnectionConfig : AbstractModel
    {
        
        /// <summary>
        /// <p>mysql数据源连接信息</p>
        /// </summary>
        [JsonProperty("MysqlConnection")]
        public MysqlConnection MysqlConnection{ get; set; }

        /// <summary>
        /// <p>hive数据源连接信息</p>
        /// </summary>
        [JsonProperty("EmrHiveConnection")]
        public HiveConnection EmrHiveConnection{ get; set; }

        /// <summary>
        /// <p>doris数据源连接信息</p>
        /// </summary>
        [JsonProperty("TCHouseDConnection")]
        public DorisConnection TCHouseDConnection{ get; set; }

        /// <summary>
        /// <p>数据卷连接信息</p>
        /// </summary>
        [JsonProperty("VolumeConnection")]
        public VolumeConnection VolumeConnection{ get; set; }

        /// <summary>
        /// <p>lakehouse连接信息</p>
        /// </summary>
        [JsonProperty("LakeHouseConnection")]
        public LakeHouseConnection LakeHouseConnection{ get; set; }

        /// <summary>
        /// <p>PostgreSQL数据源连接信息</p>
        /// </summary>
        [JsonProperty("PostgreSQLConnection")]
        public PostgreSQLConnection PostgreSQLConnection{ get; set; }

        /// <summary>
        /// <p>dlc数据源连接信息</p>
        /// </summary>
        [JsonProperty("DlcConnection")]
        public DlcConnection DlcConnection{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "MysqlConnection.", this.MysqlConnection);
            this.SetParamObj(map, prefix + "EmrHiveConnection.", this.EmrHiveConnection);
            this.SetParamObj(map, prefix + "TCHouseDConnection.", this.TCHouseDConnection);
            this.SetParamObj(map, prefix + "VolumeConnection.", this.VolumeConnection);
            this.SetParamObj(map, prefix + "LakeHouseConnection.", this.LakeHouseConnection);
            this.SetParamObj(map, prefix + "PostgreSQLConnection.", this.PostgreSQLConnection);
            this.SetParamObj(map, prefix + "DlcConnection.", this.DlcConnection);
        }
    }
}

