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

namespace TencentCloud.Tcb.V20180608.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DeleteGatewayVersionRequest : AbstractModel
    {
        
        /// <summary>
        /// 环境id
        /// </summary>
        [JsonProperty("EnvId")]
        public string EnvId{ get; set; }

        /// <summary>
        /// 网关id
        /// </summary>
        [JsonProperty("GatewayId")]
        public string GatewayId{ get; set; }

        /// <summary>
        /// 版本名
        /// </summary>
        [JsonProperty("VersionName")]
        public string VersionName{ get; set; }

        /// <summary>
        /// 是否删除服务
        /// </summary>
        [JsonProperty("IsDeleteServer")]
        public bool? IsDeleteServer{ get; set; }

        /// <summary>
        /// 是否删除镜像
        /// </summary>
        [JsonProperty("IsDeleteImage")]
        public bool? IsDeleteImage{ get; set; }

        /// <summary>
        /// 是否强制删除
        /// </summary>
        [JsonProperty("IsForce")]
        public bool? IsForce{ get; set; }

        /// <summary>
        /// 操作记录
        /// </summary>
        [JsonProperty("OperatorRemark")]
        public string OperatorRemark{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EnvId", this.EnvId);
            this.SetParamSimple(map, prefix + "GatewayId", this.GatewayId);
            this.SetParamSimple(map, prefix + "VersionName", this.VersionName);
            this.SetParamSimple(map, prefix + "IsDeleteServer", this.IsDeleteServer);
            this.SetParamSimple(map, prefix + "IsDeleteImage", this.IsDeleteImage);
            this.SetParamSimple(map, prefix + "IsForce", this.IsForce);
            this.SetParamSimple(map, prefix + "OperatorRemark", this.OperatorRemark);
        }
    }
}

