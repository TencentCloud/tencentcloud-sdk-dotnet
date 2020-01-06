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

namespace TencentCloud.Emr.V20190103.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateInstanceRequest : AbstractModel
    {
        
        /// <summary>
        /// 产品ID
        /// </summary>
        [JsonProperty("ProductId")]
        public ulong? ProductId{ get; set; }

        /// <summary>
        /// VPC设置参数
        /// </summary>
        [JsonProperty("VPCSettings")]
        public VPCSettings VPCSettings{ get; set; }

        /// <summary>
        /// 软件列表
        /// </summary>
        [JsonProperty("Software")]
        public string[] Software{ get; set; }

        /// <summary>
        /// 资源描述
        /// </summary>
        [JsonProperty("ResourceSpec")]
        public NewResourceSpec ResourceSpec{ get; set; }

        /// <summary>
        /// 支持HA
        /// </summary>
        [JsonProperty("SupportHA")]
        public ulong? SupportHA{ get; set; }

        /// <summary>
        /// 实例名称
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// 计费类型
        /// </summary>
        [JsonProperty("PayMode")]
        public ulong? PayMode{ get; set; }

        /// <summary>
        /// 集群位置信息
        /// </summary>
        [JsonProperty("Placement")]
        public Placement Placement{ get; set; }

        /// <summary>
        /// 时间长度
        /// </summary>
        [JsonProperty("TimeSpan")]
        public ulong? TimeSpan{ get; set; }

        /// <summary>
        /// 时间单位
        /// </summary>
        [JsonProperty("TimeUnit")]
        public string TimeUnit{ get; set; }

        /// <summary>
        /// 登录配置
        /// </summary>
        [JsonProperty("LoginSettings")]
        public LoginSettings LoginSettings{ get; set; }

        /// <summary>
        /// COS设置参数
        /// </summary>
        [JsonProperty("COSSettings")]
        public COSSettings COSSettings{ get; set; }

        /// <summary>
        /// 安全组ID
        /// </summary>
        [JsonProperty("SgId")]
        public string SgId{ get; set; }

        /// <summary>
        /// 预执行脚本设置
        /// </summary>
        [JsonProperty("PreExecutedFileSettings")]
        public PreExecuteFileSettings[] PreExecutedFileSettings{ get; set; }

        /// <summary>
        /// 自动续费
        /// </summary>
        [JsonProperty("AutoRenew")]
        public ulong? AutoRenew{ get; set; }

        /// <summary>
        /// 客户端Token
        /// </summary>
        [JsonProperty("ClientToken")]
        public string ClientToken{ get; set; }

        /// <summary>
        /// 是否需要外网Ip。支持填NEED_MASTER_WAN，不支持使用NOT_NEED_MASTER_WAN，默认使用NEED_MASTER_WAN
        /// </summary>
        [JsonProperty("NeedMasterWan")]
        public string NeedMasterWan{ get; set; }

        /// <summary>
        /// 是否需要开启外网远程登录，即22号端口，在SgId不为空时，该选项无效
        /// </summary>
        [JsonProperty("RemoteLoginAtCreate")]
        public long? RemoteLoginAtCreate{ get; set; }

        /// <summary>
        /// 是否开启安全集群，0表示不开启，非0表示开启
        /// </summary>
        [JsonProperty("CheckSecurity")]
        public long? CheckSecurity{ get; set; }

        /// <summary>
        /// 访问外部文件系统
        /// </summary>
        [JsonProperty("ExtendFsField")]
        public string ExtendFsField{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProductId", this.ProductId);
            this.SetParamObj(map, prefix + "VPCSettings.", this.VPCSettings);
            this.SetParamArraySimple(map, prefix + "Software.", this.Software);
            this.SetParamObj(map, prefix + "ResourceSpec.", this.ResourceSpec);
            this.SetParamSimple(map, prefix + "SupportHA", this.SupportHA);
            this.SetParamSimple(map, prefix + "InstanceName", this.InstanceName);
            this.SetParamSimple(map, prefix + "PayMode", this.PayMode);
            this.SetParamObj(map, prefix + "Placement.", this.Placement);
            this.SetParamSimple(map, prefix + "TimeSpan", this.TimeSpan);
            this.SetParamSimple(map, prefix + "TimeUnit", this.TimeUnit);
            this.SetParamObj(map, prefix + "LoginSettings.", this.LoginSettings);
            this.SetParamObj(map, prefix + "COSSettings.", this.COSSettings);
            this.SetParamSimple(map, prefix + "SgId", this.SgId);
            this.SetParamArrayObj(map, prefix + "PreExecutedFileSettings.", this.PreExecutedFileSettings);
            this.SetParamSimple(map, prefix + "AutoRenew", this.AutoRenew);
            this.SetParamSimple(map, prefix + "ClientToken", this.ClientToken);
            this.SetParamSimple(map, prefix + "NeedMasterWan", this.NeedMasterWan);
            this.SetParamSimple(map, prefix + "RemoteLoginAtCreate", this.RemoteLoginAtCreate);
            this.SetParamSimple(map, prefix + "CheckSecurity", this.CheckSecurity);
            this.SetParamSimple(map, prefix + "ExtendFsField", this.ExtendFsField);
        }
    }
}

