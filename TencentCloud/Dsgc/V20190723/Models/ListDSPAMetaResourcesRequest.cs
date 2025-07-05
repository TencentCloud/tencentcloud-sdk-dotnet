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

    public class ListDSPAMetaResourcesRequest : AbstractModel
    {
        
        /// <summary>
        /// DSPA实例ID。
        /// </summary>
        [JsonProperty("DspaId")]
        public string DspaId{ get; set; }

        /// <summary>
        /// 过滤项。
        /// 可过滤值包括：
        /// ResoureRegion - 资源所处地域，需要填写完整地域名称，不支持模糊匹配。
        /// 
        /// AuthStatus - authorized（已授权）、unauthorized（未授权）、deleted（资源已被删除），不支持模糊匹配，需要填写完整。
        /// 
        /// BuildType - cloud（云原生资源）、build（用户自建资源），不支持模糊匹配，需要填写完整。
        /// 
        /// MetaType - cdb（云数据Mysql）、dcdb（TDSQL MySQL版）、mariadb（云数据库 MariaDB）、postgres（云数据库 PostgreSQL）、cynosdbmysql（TDSQL-C MySQL版）、cos（对象存储）、mysql_like_proto（自建型Mysql协议类关系型数据库）、postgre_like_proto（自建型Postgre协议类关系型数据库）。
        /// 
        /// ResourceId - 资源ID，支持模糊搜索。
        /// 
        /// CvmID - 自建资源对应CvmId，如：ins-xxxxxxxx。该字段用于casb调用dsgc接口时，根据cvmId和vport确定具体的自建实例
        /// </summary>
        [JsonProperty("Filters")]
        public DspaDataSourceMngFilter[] Filters{ get; set; }

        /// <summary>
        /// 分页步长，默认为100。
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// 分页偏移量，默认为0。
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// 资源绑定状态过滤，默认为全部
        /// </summary>
        [JsonProperty("BindType")]
        public string BindType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DspaId", this.DspaId);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "BindType", this.BindType);
        }
    }
}

