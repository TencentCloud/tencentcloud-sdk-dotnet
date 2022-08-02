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

    public class EnvInfo : AbstractModel
    {
        
        /// <summary>
        /// 账户下该环境唯一标识
        /// </summary>
        [JsonProperty("EnvId")]
        public string EnvId{ get; set; }

        /// <summary>
        /// 环境来源。包含以下取值：
        /// <li>miniapp：微信小程序</li>
        /// <li>qcloud ：腾讯云</li>
        /// </summary>
        [JsonProperty("Source")]
        public string Source{ get; set; }

        /// <summary>
        /// 环境别名，要以a-z开头，不能包含 a-zA-z0-9- 以外的字符
        /// </summary>
        [JsonProperty("Alias")]
        public string Alias{ get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 最后修改时间
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// 环境状态。包含以下取值：
        /// <li>NORMAL：正常可用</li>
        /// <li>UNAVAILABLE：服务不可用，可能是尚未初始化或者初始化过程中</li>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 数据库列表
        /// </summary>
        [JsonProperty("Databases")]
        public DatabasesInfo[] Databases{ get; set; }

        /// <summary>
        /// 存储列表
        /// </summary>
        [JsonProperty("Storages")]
        public StorageInfo[] Storages{ get; set; }

        /// <summary>
        /// 函数列表
        /// </summary>
        [JsonProperty("Functions")]
        public FunctionInfo[] Functions{ get; set; }

        /// <summary>
        /// tcb产品套餐ID，参考DescribePackages接口的返回值。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PackageId")]
        public string PackageId{ get; set; }

        /// <summary>
        /// 套餐中文名称，参考DescribePackages接口的返回值。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PackageName")]
        public string PackageName{ get; set; }

        /// <summary>
        /// 云日志服务列表
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LogServices")]
        public LogServiceInfo[] LogServices{ get; set; }

        /// <summary>
        /// 静态资源信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("StaticStorages")]
        public StaticStorageInfo[] StaticStorages{ get; set; }

        /// <summary>
        /// 是否到期自动降为免费版
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IsAutoDegrade")]
        public bool? IsAutoDegrade{ get; set; }

        /// <summary>
        /// 环境渠道
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EnvChannel")]
        public string EnvChannel{ get; set; }

        /// <summary>
        /// 支付方式。包含以下取值：
        /// <li> prepayment：预付费</li>
        /// <li> postpaid：后付费</li>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PayMode")]
        public string PayMode{ get; set; }

        /// <summary>
        /// 是否为默认环境
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IsDefault")]
        public bool? IsDefault{ get; set; }

        /// <summary>
        /// 环境所属地域
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// 环境标签列表
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// 自定义日志服务
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CustomLogServices")]
        public ClsInfo[] CustomLogServices{ get; set; }

        /// <summary>
        /// 环境类型：baas, run, hoting, weda
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EnvType")]
        public string EnvType{ get; set; }

        /// <summary>
        /// 是否是dau新套餐
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IsDauPackage")]
        public bool? IsDauPackage{ get; set; }

        /// <summary>
        /// 套餐类型:空\baas\tcbr
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PackageType")]
        public string PackageType{ get; set; }


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
        }
    }
}

