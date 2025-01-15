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

namespace TencentCloud.Dc.V20180410.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CloudAttachInfo : AbstractModel
    {
        
        /// <summary>
        /// 敏捷上云实例id
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 敏捷上云名称
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 合作伙伴的AppId
        /// </summary>
        [JsonProperty("IapId")]
        public string IapId{ get; set; }

        /// <summary>
        /// 需要接入敏捷上云的IDC的地址
        /// </summary>
        [JsonProperty("IdcAddress")]
        public string IdcAddress{ get; set; }

        /// <summary>
        /// 需要接入敏捷上云的IDC的互联网服务提供商类型
        /// </summary>
        [JsonProperty("IdcType")]
        public string IdcType{ get; set; }

        /// <summary>
        /// 敏捷上云的带宽，单位为MB
        /// </summary>
        [JsonProperty("Bandwidth")]
        public ulong? Bandwidth{ get; set; }

        /// <summary>
        /// 联系电话
        /// </summary>
        [JsonProperty("Telephone")]
        public string Telephone{ get; set; }

        /// <summary>
        /// 敏捷上云的状态
        /// available：就绪状态
        /// applying：申请，待审核状态
        /// pendingpay：代付款状态
        /// building：建设中状态
        /// confirming：待确认状态
        /// isolate: 隔离状态
        /// stoped：终止状态
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 敏捷上云申请的时间
        /// </summary>
        [JsonProperty("ApplyTime")]
        public string ApplyTime{ get; set; }

        /// <summary>
        /// 敏捷上云建设完成的时间
        /// </summary>
        [JsonProperty("ReadyTime")]
        public string ReadyTime{ get; set; }

        /// <summary>
        /// 敏捷上云过期时间
        /// </summary>
        [JsonProperty("ExpireTime")]
        public string ExpireTime{ get; set; }

        /// <summary>
        /// 备注信息
        /// </summary>
        [JsonProperty("Remarks")]
        public string Remarks{ get; set; }

        /// <summary>
        /// 敏捷上云的地域状态。
        /// same-region：同地域
        /// cross-region：跨地域
        /// </summary>
        [JsonProperty("RegionStatus")]
        public string RegionStatus{ get; set; }

        /// <summary>
        /// 用户的AppId
        /// </summary>
        [JsonProperty("AppId")]
        public string AppId{ get; set; }

        /// <summary>
        /// 用户的Uin
        /// </summary>
        [JsonProperty("Uin")]
        public string Uin{ get; set; }

        /// <summary>
        /// 用户注册名称
        /// </summary>
        [JsonProperty("CustomerAuthName")]
        public string CustomerAuthName{ get; set; }

        /// <summary>
        /// 物理专线实例ID
        /// </summary>
        [JsonProperty("DirectConnectId")]
        public string DirectConnectId{ get; set; }

        /// <summary>
        /// 敏捷上云是否支持创建高速上云专线网关
        /// </summary>
        [JsonProperty("CloudAttachServiceGatewaysSupport")]
        public bool? CloudAttachServiceGatewaysSupport{ get; set; }

        /// <summary>
        /// 敏捷上云服务是否处于升降配中
        /// </summary>
        [JsonProperty("BUpdateBandwidth")]
        public bool? BUpdateBandwidth{ get; set; }

        /// <summary>
        /// 接入地域
        /// </summary>
        [JsonProperty("ArRegion")]
        public string ArRegion{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "IapId", this.IapId);
            this.SetParamSimple(map, prefix + "IdcAddress", this.IdcAddress);
            this.SetParamSimple(map, prefix + "IdcType", this.IdcType);
            this.SetParamSimple(map, prefix + "Bandwidth", this.Bandwidth);
            this.SetParamSimple(map, prefix + "Telephone", this.Telephone);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "ApplyTime", this.ApplyTime);
            this.SetParamSimple(map, prefix + "ReadyTime", this.ReadyTime);
            this.SetParamSimple(map, prefix + "ExpireTime", this.ExpireTime);
            this.SetParamSimple(map, prefix + "Remarks", this.Remarks);
            this.SetParamSimple(map, prefix + "RegionStatus", this.RegionStatus);
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "Uin", this.Uin);
            this.SetParamSimple(map, prefix + "CustomerAuthName", this.CustomerAuthName);
            this.SetParamSimple(map, prefix + "DirectConnectId", this.DirectConnectId);
            this.SetParamSimple(map, prefix + "CloudAttachServiceGatewaysSupport", this.CloudAttachServiceGatewaysSupport);
            this.SetParamSimple(map, prefix + "BUpdateBandwidth", this.BUpdateBandwidth);
            this.SetParamSimple(map, prefix + "ArRegion", this.ArRegion);
        }
    }
}

