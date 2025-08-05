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

namespace TencentCloud.Postgres.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyDBInstanceSecurityGroupsRequest : AbstractModel
    {
        
        /// <summary>
        /// 实例或只读组要绑定的安全组列表。
        /// 安全组信息可以通过调用 [DescribeSecurityGroups](https://cloud.tencent.com/document/api/215/15808) 的返回值中的sgId字段来查询。
        /// **注意：**该入参会全量替换存量已有集合，非增量更新。修改需传入预期的全量集合。
        /// </summary>
        [JsonProperty("SecurityGroupIdSet")]
        public string[] SecurityGroupIdSet{ get; set; }

        /// <summary>
        /// 实例ID，可通过[DescribeDBInstances](https://cloud.tencent.com/document/api/409/16773)接口获取。DBInstanceId和ReadOnlyGroupId至少传一个；如果都传，忽略ReadOnlyGroupId。
        /// </summary>
        [JsonProperty("DBInstanceId")]
        public string DBInstanceId{ get; set; }

        /// <summary>
        /// 只读组ID，可通过[DescribeReadOnlyGroups](https://cloud.tencent.com/document/api/409/52599)接口获取。DBInstanceId和ReadOnlyGroupId至少传一个；如果要修改只读组关联的安全组，只传ReadOnlyGroupId
        /// </summary>
        [JsonProperty("ReadOnlyGroupId")]
        public string ReadOnlyGroupId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "SecurityGroupIdSet.", this.SecurityGroupIdSet);
            this.SetParamSimple(map, prefix + "DBInstanceId", this.DBInstanceId);
            this.SetParamSimple(map, prefix + "ReadOnlyGroupId", this.ReadOnlyGroupId);
        }
    }
}

