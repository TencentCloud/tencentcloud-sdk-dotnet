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

    public class VpcFwGroupInfo : AbstractModel
    {
        
        /// <summary>
        /// 防火墙(组)ID
        /// </summary>
        [JsonProperty("FwGroupId")]
        public string FwGroupId{ get; set; }

        /// <summary>
        /// 防火墙(组)名称
        /// </summary>
        [JsonProperty("FwGroupName")]
        public string FwGroupName{ get; set; }

        /// <summary>
        /// 防火墙组涉及到的开关个数
        /// </summary>
        [JsonProperty("FwSwitchNum")]
        public long? FwSwitchNum{ get; set; }

        /// <summary>
        /// 防火墙(组)部署的地域
        /// </summary>
        [JsonProperty("RegionLst")]
        public string[] RegionLst{ get; set; }

        /// <summary>
        /// 模式 1：CCN云联网模式；0：私有网络模式 2: sase 模式 3：ccn 高级模式 4: 私有网络(跨租户单边模式)
        /// </summary>
        [JsonProperty("Mode")]
        public long? Mode{ get; set; }

        /// <summary>
        /// 防火墙实例的开关模式 1: 单点互通 2: 多点互通 3: 全互通 4: 自定义路由
        /// </summary>
        [JsonProperty("SwitchMode")]
        public long? SwitchMode{ get; set; }

        /// <summary>
        /// VPC防火墙实例卡片信息数组
        /// </summary>
        [JsonProperty("FwInstanceLst")]
        public VpcFwInstanceInfo[] FwInstanceLst{ get; set; }

        /// <summary>
        /// 防火墙(状态) 0：正常 1: 初始化或操作中
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// auto :自动选择
        /// 如果为网段，则为用户自定义 192.168.0.0/20 
        /// </summary>
        [JsonProperty("FwVpcCidr")]
        public string FwVpcCidr{ get; set; }

        /// <summary>
        /// cdc专用集群场景时表示部署所属的cdc
        /// </summary>
        [JsonProperty("CdcId")]
        public string CdcId{ get; set; }

        /// <summary>
        /// cdc专用集群场景时表示cdc名称
        /// </summary>
        [JsonProperty("CdcName")]
        public string CdcName{ get; set; }

        /// <summary>
        /// 跨租户模式 1管理员 2单边 0 非跨租户
        /// </summary>
        [JsonProperty("CrossUserMode")]
        public string CrossUserMode{ get; set; }

        /// <summary>
        /// 云联网模式下，当前实例是否需要开启重叠路由开关，1：需要开启，0：不需要开启
        /// </summary>
        [JsonProperty("NeedSwitchCcnOverlap")]
        public long? NeedSwitchCcnOverlap{ get; set; }

        /// <summary>
        /// 云联网模式下，实例关联的云联网id
        /// </summary>
        [JsonProperty("CcnId")]
        public string CcnId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FwGroupId", this.FwGroupId);
            this.SetParamSimple(map, prefix + "FwGroupName", this.FwGroupName);
            this.SetParamSimple(map, prefix + "FwSwitchNum", this.FwSwitchNum);
            this.SetParamArraySimple(map, prefix + "RegionLst.", this.RegionLst);
            this.SetParamSimple(map, prefix + "Mode", this.Mode);
            this.SetParamSimple(map, prefix + "SwitchMode", this.SwitchMode);
            this.SetParamArrayObj(map, prefix + "FwInstanceLst.", this.FwInstanceLst);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "FwVpcCidr", this.FwVpcCidr);
            this.SetParamSimple(map, prefix + "CdcId", this.CdcId);
            this.SetParamSimple(map, prefix + "CdcName", this.CdcName);
            this.SetParamSimple(map, prefix + "CrossUserMode", this.CrossUserMode);
            this.SetParamSimple(map, prefix + "NeedSwitchCcnOverlap", this.NeedSwitchCcnOverlap);
            this.SetParamSimple(map, prefix + "CcnId", this.CcnId);
        }
    }
}

