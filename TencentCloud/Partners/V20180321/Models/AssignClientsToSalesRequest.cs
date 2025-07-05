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

namespace TencentCloud.Partners.V20180321.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AssignClientsToSalesRequest : AbstractModel
    {
        
        /// <summary>
        /// 代客/申请中代客uin列表，最大50条
        /// </summary>
        [JsonProperty("ClientUins")]
        public string[] ClientUins{ get; set; }

        /// <summary>
        /// 业务员uin
        /// </summary>
        [JsonProperty("SalesUin")]
        public string SalesUin{ get; set; }

        /// <summary>
        /// 代客类型:normal-代客 apply-申请中代客
        /// </summary>
        [JsonProperty("AssignClientStatus")]
        public string AssignClientStatus{ get; set; }

        /// <summary>
        /// 操作类型:assign-执行分派 cancel-取消分派
        /// </summary>
        [JsonProperty("AssignActionType")]
        public string AssignActionType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "ClientUins.", this.ClientUins);
            this.SetParamSimple(map, prefix + "SalesUin", this.SalesUin);
            this.SetParamSimple(map, prefix + "AssignClientStatus", this.AssignClientStatus);
            this.SetParamSimple(map, prefix + "AssignActionType", this.AssignActionType);
        }
    }
}

