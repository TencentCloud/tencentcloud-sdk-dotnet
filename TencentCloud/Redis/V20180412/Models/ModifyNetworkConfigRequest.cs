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

namespace TencentCloud.Redis.V20180412.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyNetworkConfigRequest : AbstractModel
    {
        
        /// <summary>
        /// 实例 ID，请登录[Redis控制台](https://console.cloud.tencent.com/redis/instance/list)在实例列表复制实例 ID。
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 指预修改网络的类别，包括：
        /// - changeVip：指切换私有网络，包含其内网IPv4地址及端口。
        /// - changeVpc：指切换私有网络所属子网。
        /// - changeBaseToVpc：指基础网络切换为私有网络。
        /// - changeVPort：指仅修改实例网络端口。
        /// </summary>
        [JsonProperty("Operation")]
        public string Operation{ get; set; }

        /// <summary>
        /// 指实例私有网络内网 IPv4 地址。当**Operation**为**changeVip**时，需配置该参数。
        /// </summary>
        [JsonProperty("Vip")]
        public string Vip{ get; set; }

        /// <summary>
        /// 指修改后的私有网络 ID。
        /// - 当**Operation**为**changeVpc**或**changeBaseToVpc**时，需配置该参数。
        /// - 请登录[Redis控制台](https://console.cloud.tencent.com/redis/instance/list)，切换至**实例详情**页面，在**网络信息**区域，单击所属网络后面的私有网络名称，获取私有网络 ID。
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// 指修改后的私有网络所属子网 ID。
        /// - 当**Operation**为**changeVpc**或**changeBaseToVpc**时，需配置该参数。
        /// - 请登录[Redis控制台](https://console.cloud.tencent.com/redis/instance/list)，切换至**实例详情**页面，在**网络信息**区域，单击所属网络后面的子网名称，获取子网ID。
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }

        /// <summary>
        /// 原内网 IPv4 地址保留时长。
        /// - 单位：天。
        /// - 取值范围：0、1、2、3、7、15。
        /// **说明**：保留时长不设置或者设置为0，原网络地址将立即释放。
        /// </summary>
        [JsonProperty("Recycle")]
        public long? Recycle{ get; set; }

        /// <summary>
        /// 指修改后的网络端口。当**Operation**为**changeVPort**或**changeVip**时，需配置该参数。取值范围为[1024,65535]。
        /// </summary>
        [JsonProperty("VPort")]
        public long? VPort{ get; set; }


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
            this.SetParamSimple(map, prefix + "VPort", this.VPort);
        }
    }
}

