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

namespace TencentCloud.Ckafka.V20190819.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DeleteRouteRequest : AbstractModel
    {
        
        /// <summary>
        /// 实例唯一id
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 路由id
        /// </summary>
        [JsonProperty("RouteId")]
        public long? RouteId{ get; set; }

        /// <summary>
        /// 调用方appId
        /// </summary>
        [JsonProperty("CallerAppid")]
        public long? CallerAppid{ get; set; }

        /// <summary>
        /// 删除路由时间
        /// </summary>
        [JsonProperty("DeleteRouteTime")]
        public string DeleteRouteTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "RouteId", this.RouteId);
            this.SetParamSimple(map, prefix + "CallerAppid", this.CallerAppid);
            this.SetParamSimple(map, prefix + "DeleteRouteTime", this.DeleteRouteTime);
        }
    }
}

