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

namespace TencentCloud.Dts.V20180330.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateMigrateJobRequest : AbstractModel
    {
        
        /// <summary>
        /// 数据迁移任务名称
        /// </summary>
        [JsonProperty("JobName")]
        public string JobName{ get; set; }

        /// <summary>
        /// 迁移任务配置选项
        /// </summary>
        [JsonProperty("MigrateOption")]
        public MigrateOption MigrateOption{ get; set; }

        /// <summary>
        /// 源实例数据库类型，目前支持：mysql，redis，mongodb，postgresql，mariadb，percona。不同地域数据库类型的具体支持情况，请参考控制台创建迁移页面。
        /// </summary>
        [JsonProperty("SrcDatabaseType")]
        public string SrcDatabaseType{ get; set; }

        /// <summary>
        /// 源实例接入类型，值包括：extranet(外网),cvm(cvm自建实例),dcg(专线接入的实例),vpncloud(云vpn接入的实例),cdb(腾讯云数据库实例),ccn(云联网实例)
        /// </summary>
        [JsonProperty("SrcAccessType")]
        public string SrcAccessType{ get; set; }

        /// <summary>
        /// 源实例信息，具体内容跟迁移任务类型相关
        /// </summary>
        [JsonProperty("SrcInfo")]
        public SrcInfo SrcInfo{ get; set; }

        /// <summary>
        /// 目标实例数据库类型，目前支持：mysql，redis，mongodb，postgresql，mariadb，percona。不同地域数据库类型的具体支持情况，请参考控制台创建迁移页面。
        /// </summary>
        [JsonProperty("DstDatabaseType")]
        public string DstDatabaseType{ get; set; }

        /// <summary>
        /// 目标实例接入类型，目前支持：cdb（腾讯云数据库实例）
        /// </summary>
        [JsonProperty("DstAccessType")]
        public string DstAccessType{ get; set; }

        /// <summary>
        /// 目标实例信息
        /// </summary>
        [JsonProperty("DstInfo")]
        public DstInfo DstInfo{ get; set; }

        /// <summary>
        /// 需要迁移的源数据库表信息，用json格式的字符串描述。当MigrateOption.MigrateObject配置为2（指定库表迁移）时必填。
        /// 对于database-table两级结构的数据库：
        /// [{Database:db1,Table:[table1,table2]},{Database:db2}]
        /// 对于database-schema-table三级结构：
        /// [{Database:db1,Schema:s1
        /// Table:[table1,table2]},{Database:db1,Schema:s2
        /// Table:[table1,table2]},{Database:db2,Schema:s1
        /// Table:[table1,table2]},{Database:db3},{Database:db4
        /// Schema:s1}]
        /// </summary>
        [JsonProperty("DatabaseInfo")]
        public string DatabaseInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "JobName", this.JobName);
            this.SetParamObj(map, prefix + "MigrateOption.", this.MigrateOption);
            this.SetParamSimple(map, prefix + "SrcDatabaseType", this.SrcDatabaseType);
            this.SetParamSimple(map, prefix + "SrcAccessType", this.SrcAccessType);
            this.SetParamObj(map, prefix + "SrcInfo.", this.SrcInfo);
            this.SetParamSimple(map, prefix + "DstDatabaseType", this.DstDatabaseType);
            this.SetParamSimple(map, prefix + "DstAccessType", this.DstAccessType);
            this.SetParamObj(map, prefix + "DstInfo.", this.DstInfo);
            this.SetParamSimple(map, prefix + "DatabaseInfo", this.DatabaseInfo);
        }
    }
}

