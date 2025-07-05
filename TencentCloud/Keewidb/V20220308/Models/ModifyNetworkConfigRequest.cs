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

namespace TencentCloud.Keewidb.V20220308.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyNetworkConfigRequest : AbstractModel
    {
        
        /// <summary>
        /// 实例 ID，如：kee-6ubh****。
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 操作类型。<ul><li>changeVip：修改实例私有网络。</li><li>changeVpc：修改实例私有网络所属子网。</li><li>changeBaseToVpc：基础网络转为私有网络。</li></ul>
        /// </summary>
        [JsonProperty("Operation")]
        public string Operation{ get; set; }

        /// <summary>
        /// 修改后的 VIP 地址。
        /// 当参数<b>Operation</b>为<b>changeVip</b>时，需设置实例修改后的 VIP 地址。该参数不配置，则自动分配。
        /// </summary>
        [JsonProperty("Vip")]
        public string Vip{ get; set; }

        /// <summary>
        /// 修改后的私有网络 ID。
        /// 当参数<b>Operation</b>为<b>changeVip</b>或者为<b>changeBaseToVpc</b>时，务必设置实例修改后的私有网络 ID。
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// 修改后的所属子网 ID。
        /// 当参数<b>Operation</b>为<b>changeVpc</b>或者为<b>changeBaseToVpc</b>时，务必设置实例修改后的子网 ID。
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }

        /// <summary>
        /// 原 VIP 保留时长。
        /// 单位：天。取值范围：0、1、2、3、7、15。
        /// </summary>
        [JsonProperty("Recycle")]
        public long? Recycle{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "Operation", this.Operation);
            this.SetParamSimple(map, prefix + "Vip", this.Vip);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "SubnetId", this.SubnetId);
            this.SetParamSimple(map, prefix + "Recycle", this.Recycle);
        }
    }
}

