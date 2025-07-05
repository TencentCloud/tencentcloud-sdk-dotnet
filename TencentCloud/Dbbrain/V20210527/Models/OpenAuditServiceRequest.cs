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

namespace TencentCloud.Dbbrain.V20210527.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class OpenAuditServiceRequest : AbstractModel
    {
        
        /// <summary>
        /// 服务产品类型，支持值包括： "dcdb" - 云数据库 Tdsql， "mariadb" - 云数据库 MariaDB。
        /// </summary>
        [JsonProperty("Product")]
        public string Product{ get; set; }

        /// <summary>
        /// 与Product保持一致。如："dcdb" ,"mariadb"。
        /// </summary>
        [JsonProperty("NodeRequestType")]
        public string NodeRequestType{ get; set; }

        /// <summary>
        /// 实例ID。
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 日志保存总时长，只能是7,30,90,180,365,1095,1825。
        /// </summary>
        [JsonProperty("LogExpireDay")]
        public long? LogExpireDay{ get; set; }

        /// <summary>
        /// 高频日志保存时长，只能是7,30,90,180,365,1095,1825。
        /// </summary>
        [JsonProperty("HotLogExpireDay")]
        public long? HotLogExpireDay{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Product", this.Product);
            this.SetParamSimple(map, prefix + "NodeRequestType", this.NodeRequestType);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "LogExpireDay", this.LogExpireDay);
            this.SetParamSimple(map, prefix + "HotLogExpireDay", this.HotLogExpireDay);
        }
    }
}

