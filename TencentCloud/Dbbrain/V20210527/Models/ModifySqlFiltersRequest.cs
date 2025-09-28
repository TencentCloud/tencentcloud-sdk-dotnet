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

    public class ModifySqlFiltersRequest : AbstractModel
    {
        
        /// <summary>
        /// 实例 ID。可通过 [DescribeDiagDBInstances](https://cloud.tencent.com/document/api/1130/57798) 接口获取。
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// SQL限流任务ID列表。可通过接口[查询实例SQL限流任务列表
        /// ](https://cloud.tencent.com/document/product/1130/72831)获得。
        /// </summary>
        [JsonProperty("FilterIds")]
        public long?[] FilterIds{ get; set; }

        /// <summary>
        /// 限流任务状态，仅支持传参TERMINATED - 终止。
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 通过 [VerifyUserAccount](https://cloud.tencent.com/document/product/1130/72828) 获取有效期为5分钟的会话token，使用后会自动延长token有效期至五分钟后。
        /// </summary>
        [JsonProperty("SessionToken")]
        public string SessionToken{ get; set; }

        /// <summary>
        /// 服务产品类型，支持值："mysql" - 云数据库 MySQL；"cynosdb" - 云数据库 TDSQL-C for MySQL，默认为"mysql"。
        /// </summary>
        [JsonProperty("Product")]
        public string Product{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamArraySimple(map, prefix + "FilterIds.", this.FilterIds);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "SessionToken", this.SessionToken);
            this.SetParamSimple(map, prefix + "Product", this.Product);
        }
    }
}

