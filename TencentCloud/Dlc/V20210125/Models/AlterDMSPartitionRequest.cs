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

namespace TencentCloud.Dlc.V20210125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AlterDMSPartitionRequest : AbstractModel
    {
        
        /// <summary>
        /// 当前名称，变更前db名称
        /// </summary>
        [JsonProperty("CurrentDbName")]
        public string CurrentDbName{ get; set; }

        /// <summary>
        /// 当前名称，变更前table名称
        /// </summary>
        [JsonProperty("CurrentTableName")]
        public string CurrentTableName{ get; set; }

        /// <summary>
        /// 当前名称，变更前Part名称
        /// </summary>
        [JsonProperty("CurrentValues")]
        public string CurrentValues{ get; set; }

        /// <summary>
        /// 分区
        /// </summary>
        [JsonProperty("Partition")]
        public DMSPartition Partition{ get; set; }

        /// <summary>
        /// 数据源连接名
        /// </summary>
        [JsonProperty("DatasourceConnectionName")]
        public string DatasourceConnectionName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CurrentDbName", this.CurrentDbName);
            this.SetParamSimple(map, prefix + "CurrentTableName", this.CurrentTableName);
            this.SetParamSimple(map, prefix + "CurrentValues", this.CurrentValues);
            this.SetParamObj(map, prefix + "Partition.", this.Partition);
            this.SetParamSimple(map, prefix + "DatasourceConnectionName", this.DatasourceConnectionName);
        }
    }
}

