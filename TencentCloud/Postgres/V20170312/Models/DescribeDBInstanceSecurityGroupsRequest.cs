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

    public class DescribeDBInstanceSecurityGroupsRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>实例ID，可通过<a href="https://cloud.tencent.com/document/api/409/16773">DescribeDBInstances</a>接口获取。DBInstanceId、ReadOnlyGroupId、ProxyAddressId至少传一个；如果要查询实例关联的安全组，只传DBInstanceId字段。</p>
        /// </summary>
        [JsonProperty("DBInstanceId")]
        public string DBInstanceId{ get; set; }

        /// <summary>
        /// <p>只读组ID，可通过<a href="https://cloud.tencent.com/document/api/409/52599">DescribeReadOnlyGroups</a>接口获取。DBInstanceId、ReadOnlyGroupId、ProxyAddressId至少传一个；如果要查询只读组关联的安全组，只传ReadOnlyGroupId。</p>
        /// </summary>
        [JsonProperty("ReadOnlyGroupId")]
        public string ReadOnlyGroupId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DBInstanceId", this.DBInstanceId);
            this.SetParamSimple(map, prefix + "ReadOnlyGroupId", this.ReadOnlyGroupId);
        }
    }
}

