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

namespace TencentCloud.Dcdb.V20180411.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeDatabaseObjectsResponse : AbstractModel
    {
        
        /// <summary>
        /// 透传入参。
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 数据库名称。
        /// </summary>
        [JsonProperty("DbName")]
        public string DbName{ get; set; }

        /// <summary>
        /// 表列表。
        /// </summary>
        [JsonProperty("Tables")]
        public DatabaseTable[] Tables{ get; set; }

        /// <summary>
        /// 视图列表。
        /// </summary>
        [JsonProperty("Views")]
        public DatabaseView[] Views{ get; set; }

        /// <summary>
        /// 存储过程列表。
        /// </summary>
        [JsonProperty("Procs")]
        public DatabaseProcedure[] Procs{ get; set; }

        /// <summary>
        /// 函数列表。
        /// </summary>
        [JsonProperty("Funcs")]
        public DatabaseFunction[] Funcs{ get; set; }

        /// <summary>
        /// 唯一请求 ID，每次请求都会返回。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "DbName", this.DbName);
            this.SetParamArrayObj(map, prefix + "Tables.", this.Tables);
            this.SetParamArrayObj(map, prefix + "Views.", this.Views);
            this.SetParamArrayObj(map, prefix + "Procs.", this.Procs);
            this.SetParamArrayObj(map, prefix + "Funcs.", this.Funcs);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

