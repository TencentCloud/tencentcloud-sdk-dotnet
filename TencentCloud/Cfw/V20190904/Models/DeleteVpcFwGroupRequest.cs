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

namespace TencentCloud.Cfw.V20190904.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DeleteVpcFwGroupRequest : AbstractModel
    {
        
        /// <summary>
        /// 防火墙(组)Id
        /// </summary>
        [JsonProperty("FwGroupId")]
        public string FwGroupId{ get; set; }

        /// <summary>
        /// 是否删除整个防火墙(组)
        /// 0：不删除防火墙(组)，只删除单独实例
        /// 1：删除整个防火墙(组)
        /// </summary>
        [JsonProperty("DeleteFwGroup")]
        public long? DeleteFwGroup{ get; set; }

        /// <summary>
        /// 待删除的防火墙实例数组
        /// </summary>
        [JsonProperty("VpcFwInsList")]
        public string[] VpcFwInsList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FwGroupId", this.FwGroupId);
            this.SetParamSimple(map, prefix + "DeleteFwGroup", this.DeleteFwGroup);
            this.SetParamArraySimple(map, prefix + "VpcFwInsList.", this.VpcFwInsList);
        }
    }
}

