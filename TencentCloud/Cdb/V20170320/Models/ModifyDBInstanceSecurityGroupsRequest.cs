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

namespace TencentCloud.Cdb.V20170320.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyDBInstanceSecurityGroupsRequest : AbstractModel
    {
        
        /// <summary>
        /// 实例 ID，格式如：cdb-c1nl9rpv 或者 cdbro-c1nl9rpv，与云数据库控制台页面中显示的实例 ID 相同。
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 要修改的安全组 ID 列表，一个或者多个安全组 ID 组成的数组。可通过 [DescribeDBSecurityGroups](https://cloud.tencent.com/document/product/236/15854) 接口获取。输入的安全组 ID 数组无长度限制。
        /// 注意：该入参会全量替换存量已有集合，非增量更新。修改需传入预期的全量集合。
        /// </summary>
        [JsonProperty("SecurityGroupIds")]
        public string[] SecurityGroupIds{ get; set; }

        /// <summary>
        /// 当传入只读实例 ID 时，默认操作的是对应只读组的安全组。如果需要操作只读实例 ID 的安全组， 需要将该入参置为 True。默认为 False。
        /// </summary>
        [JsonProperty("ForReadonlyInstance")]
        public bool? ForReadonlyInstance{ get; set; }

        /// <summary>
        /// 变更云盘版实例只读组时，InstanceId 传实例 ID，需要额外指定该参数表示操作只读组。 如果操作读写节点则不需指定该参数。
        /// </summary>
        [JsonProperty("OpResourceId")]
        public string OpResourceId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamArraySimple(map, prefix + "SecurityGroupIds.", this.SecurityGroupIds);
            this.SetParamSimple(map, prefix + "ForReadonlyInstance", this.ForReadonlyInstance);
            this.SetParamSimple(map, prefix + "OpResourceId", this.OpResourceId);
        }
    }
}

