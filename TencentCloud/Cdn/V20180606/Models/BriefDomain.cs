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

namespace TencentCloud.Cdn.V20180606.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class BriefDomain : AbstractModel
    {
        
        /// <summary>
        /// 域名 ID
        /// </summary>
        [JsonProperty("ResourceId")]
        public string ResourceId{ get; set; }

        /// <summary>
        /// 腾讯云账号 ID
        /// </summary>
        [JsonProperty("AppId")]
        public long? AppId{ get; set; }

        /// <summary>
        /// 加速域名
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }

        /// <summary>
        /// 域名对应的 CNAME 地址
        /// </summary>
        [JsonProperty("Cname")]
        public string Cname{ get; set; }

        /// <summary>
        /// 加速服务状态
        /// rejected：域名审核未通过，域名备案过期/被注销导致
        /// processing：部署中
        /// online：已启动
        /// offline：已关闭
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 项目 ID，可前往腾讯云项目管理页面查看
        /// </summary>
        [JsonProperty("ProjectId")]
        public long? ProjectId{ get; set; }

        /// <summary>
        /// 域名业务类型
        /// web：静态加速
        /// download：下载加速
        /// media：流媒体点播加速
        /// </summary>
        [JsonProperty("ServiceType")]
        public string ServiceType{ get; set; }

        /// <summary>
        /// 域名创建时间
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 域名更新时间
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// 源站配置详情
        /// </summary>
        [JsonProperty("Origin")]
        public Origin Origin{ get; set; }

        /// <summary>
        /// 域名封禁状态
        /// normal：正常状态
        /// overdue：账号欠费导致域名关闭，充值完成后可自行启动加速服务
        /// malicious：域名出现恶意行为，强制关闭加速服务
        /// ddos：域名被大规模 DDoS 攻击，关闭加速服务
        /// idle：域名超过 90 天内无任何操作、数据产生，判定为不活跃域名自动关闭加速服务，可自行启动加速服务
        /// unlicensed：域名未备案/备案注销，自动关闭加速服务，备案完成后可自行启动加速服务
        /// capping：触发配置的带宽阈值上限
        /// readonly：域名存在特殊配置，被锁定
        /// </summary>
        [JsonProperty("Disable")]
        public string Disable{ get; set; }

        /// <summary>
        /// 加速区域
        /// mainland：中国境内加速
        /// overseas：中国境外加速
        /// global：全球加速
        /// </summary>
        [JsonProperty("Area")]
        public string Area{ get; set; }

        /// <summary>
        /// 域名锁定状态
        /// normal：未锁定
        /// mainland：中国境内锁定
        /// overseas：中国境外锁定
        /// global：全球锁定
        /// </summary>
        [JsonProperty("Readonly")]
        public string Readonly{ get; set; }

        /// <summary>
        /// 域名所属产品，cdn/ecdn
        /// </summary>
        [JsonProperty("Product")]
        public string Product{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ResourceId", this.ResourceId);
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
            this.SetParamSimple(map, prefix + "Cname", this.Cname);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "ServiceType", this.ServiceType);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamObj(map, prefix + "Origin.", this.Origin);
            this.SetParamSimple(map, prefix + "Disable", this.Disable);
            this.SetParamSimple(map, prefix + "Area", this.Area);
            this.SetParamSimple(map, prefix + "Readonly", this.Readonly);
            this.SetParamSimple(map, prefix + "Product", this.Product);
        }
    }
}

