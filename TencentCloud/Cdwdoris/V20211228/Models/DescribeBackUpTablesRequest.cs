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

namespace TencentCloud.Cdwdoris.V20211228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeBackUpTablesRequest : AbstractModel
    {
        
        /// <summary>
        /// 集群id
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 0为默认。1时是对远端的doris进行备份，不周期，一次性。2时为cos恢复，一次性
        /// </summary>
        [JsonProperty("BackupType")]
        public long? BackupType{ get; set; }

        /// <summary>
        /// 远端doris集群的连接信息
        /// </summary>
        [JsonProperty("DorisSourceInfo")]
        public DorisSourceInfo DorisSourceInfo{ get; set; }

        /// <summary>
        /// cos信息
        /// </summary>
        [JsonProperty("CosSourceInfo")]
        public CosSourceInfo CosSourceInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "BackupType", this.BackupType);
            this.SetParamObj(map, prefix + "DorisSourceInfo.", this.DorisSourceInfo);
            this.SetParamObj(map, prefix + "CosSourceInfo.", this.CosSourceInfo);
        }
    }
}

