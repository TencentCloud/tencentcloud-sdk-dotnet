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

namespace TencentCloud.Cdwdoris.V20211228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ScaleUpInstanceRequest : AbstractModel
    {
        
        /// <summary>
        /// 集群ID
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 节点规格
        /// </summary>
        [JsonProperty("SpecName")]
        public string SpecName{ get; set; }

        /// <summary>
        /// 角色（MASTER/CORE），MASTER 对应 FE，CORE对应BE
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 前端鉴权使用，后端API调用传false，传true不会执行变配
        /// </summary>
        [JsonProperty("CheckAuth")]
        public bool? CheckAuth{ get; set; }

        /// <summary>
        /// 是否滚动重启
        /// </summary>
        [JsonProperty("RollingRestart")]
        public bool? RollingRestart{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "SpecName", this.SpecName);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "CheckAuth", this.CheckAuth);
            this.SetParamSimple(map, prefix + "RollingRestart", this.RollingRestart);
        }
    }
}

