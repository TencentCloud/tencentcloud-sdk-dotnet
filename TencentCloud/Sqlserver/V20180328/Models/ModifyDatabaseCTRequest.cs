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

namespace TencentCloud.Sqlserver.V20180328.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyDatabaseCTRequest : AbstractModel
    {
        
        /// <summary>
        /// 数据库名数组
        /// </summary>
        [JsonProperty("DBNames")]
        public string[] DBNames{ get; set; }

        /// <summary>
        /// 启用、禁用数据库CT功能 enable；启用，disable：禁用
        /// </summary>
        [JsonProperty("ModifyType")]
        public string ModifyType{ get; set; }

        /// <summary>
        /// 实例ID
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 启用CT时额外保留天数，默认保留3天，最小3天，最大30天
        /// </summary>
        [JsonProperty("ChangeRetentionDay")]
        public long? ChangeRetentionDay{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "DBNames.", this.DBNames);
            this.SetParamSimple(map, prefix + "ModifyType", this.ModifyType);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "ChangeRetentionDay", this.ChangeRetentionDay);
        }
    }
}

