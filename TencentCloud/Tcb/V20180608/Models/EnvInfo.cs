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

namespace TencentCloud.Tcb.V20180608.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class EnvInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>账户下该环境唯一标识</p>
        /// </summary>
        [JsonProperty("EnvId")]
        public string EnvId{ get; set; }

        /// <summary>
        /// <p>环境来源。包含以下取值：</p><li>miniapp：微信小程序</li><li>qcloud ：腾讯云</li>
        /// </summary>
        [JsonProperty("Source")]
        public string Source{ get; set; }

        /// <summary>
        /// <p>环境别名，要以a-z开头，不能包含 a-zA-z0-9- 以外的字符</p>
        /// </summary>
        [JsonProperty("Alias")]
        public string Alias{ get; set; }

        /// <summary>
        /// <p>创建时间</p>
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// <p>最后修改时间</p>
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// <p>环境状态。包含以下取值：</p><li>NORMAL：正常可用</li><li>UNAVAILABLE：服务不可用，可能是尚未初始化或者初始化过程中</li>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// <p>数据库列表</p>
        /// </summary>
        [JsonProperty("Databases")]
        public DatabasesInfo[] Databases{ get; set; }

        /// <summary>
        /// <p>存储列表</p>
        /// </summary>
        [JsonProperty("Storages")]
        public StorageInfo[] Storages{ get; set; }

        /// <summary>
        /// <p>函数列表</p>
        /// </summary>
        [JsonProperty("Functions")]
        public FunctionInfo[] Functions{ get; set; }

        /// <summary>
        /// <p>tcb产品套餐ID，参考DescribePackages接口的返回值。</p>
        /// </summary>
        [JsonProperty("PackageId")]
        public string PackageId{ get; set; }

        /// <summary>
        /// <p>套餐中文名称，参考DescribePackages接口的返回值。</p>
        /// </summary>
        [JsonProperty("PackageName")]
        public string PackageName{ get; set; }

        /// <summary>
        /// <p>云日志服务列表</p>
        /// </summary>
        [JsonProperty("LogServices")]
        public LogServiceInfo[] LogServices{ get; set; }

        /// <summary>
        /// <p>静态资源信息</p>
        /// </summary>
        [JsonProperty("StaticStorages")]
        public StaticStorageInfo[] StaticStorages{ get; set; }

        /// <summary>
        /// <p>是否到期自动降为免费版</p>
        /// </summary>
        [JsonProperty("IsAutoDegrade")]
        public bool? IsAutoDegrade{ get; set; }

        /// <summary>
        /// <p>环境渠道</p>
        /// </summary>
        [JsonProperty("EnvChannel")]
        public string EnvChannel{ get; set; }

        /// <summary>
        /// <p>支付方式。包含以下取值：</p><li> prepayment：预付费</li><li> postpaid：后付费</li>
        /// </summary>
        [JsonProperty("PayMode")]
        public string PayMode{ get; set; }

        /// <summary>
        /// <p>是否为默认环境</p>
        /// </summary>
        [JsonProperty("IsDefault")]
        public bool? IsDefault{ get; set; }

        /// <summary>
        /// <p>环境所属地域</p>
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// <p>环境标签列表</p>
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// <p>自定义日志服务</p>
        /// </summary>
        [JsonProperty("CustomLogServices")]
        public ClsInfo[] CustomLogServices{ get; set; }

        /// <summary>
        /// <p>环境类型：baas, run, hoting, weda</p>
        /// </summary>
        [JsonProperty("EnvType")]
        public string EnvType{ get; set; }

        /// <summary>
        /// <p>是否是dau新套餐</p>
        /// </summary>
        [JsonProperty("IsDauPackage")]
        public bool? IsDauPackage{ get; set; }

        /// <summary>
        /// <p>套餐类型:空\baas\tcbr</p>
        /// </summary>
        [JsonProperty("PackageType")]
        public string PackageType{ get; set; }

        /// <summary>
        /// <p>架构类型</p>
        /// </summary>
        [JsonProperty("ArchitectureType")]
        public string ArchitectureType{ get; set; }

        /// <summary>
        /// <p>回收标志，默认为空</p>
        /// </summary>
        [JsonProperty("Recycle")]
        public string Recycle{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EnvId", this.EnvId);
            this.SetParamSimple(map, prefix + "Source", this.Source);
            this.SetParamSimple(map, prefix + "Alias", this.Alias);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamArrayObj(map, prefix + "Databases.", this.Databases);
            this.SetParamArrayObj(map, prefix + "Storages.", this.Storages);
            this.SetParamArrayObj(map, prefix + "Functions.", this.Functions);
            this.SetParamSimple(map, prefix + "PackageId", this.PackageId);
            this.SetParamSimple(map, prefix + "PackageName", this.PackageName);
            this.SetParamArrayObj(map, prefix + "LogServices.", this.LogServices);
            this.SetParamArrayObj(map, prefix + "StaticStorages.", this.StaticStorages);
            this.SetParamSimple(map, prefix + "IsAutoDegrade", this.IsAutoDegrade);
            this.SetParamSimple(map, prefix + "EnvChannel", this.EnvChannel);
            this.SetParamSimple(map, prefix + "PayMode", this.PayMode);
            this.SetParamSimple(map, prefix + "IsDefault", this.IsDefault);
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamArrayObj(map, prefix + "CustomLogServices.", this.CustomLogServices);
            this.SetParamSimple(map, prefix + "EnvType", this.EnvType);
            this.SetParamSimple(map, prefix + "IsDauPackage", this.IsDauPackage);
            this.SetParamSimple(map, prefix + "PackageType", this.PackageType);
            this.SetParamSimple(map, prefix + "ArchitectureType", this.ArchitectureType);
            this.SetParamSimple(map, prefix + "Recycle", this.Recycle);
        }
    }
}

