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

namespace TencentCloud.Ctem.V20231128.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Customer : AbstractModel
    {
        
        /// <summary>
        /// <p>企业ID</p>
        /// </summary>
        [JsonProperty("Id")]
        public ulong? Id{ get; set; }

        /// <summary>
        /// <p>企业名称</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>股权占比</p>
        /// </summary>
        [JsonProperty("Percent")]
        public long? Percent{ get; set; }

        /// <summary>
        /// <p>资产收集、漏洞信息、弱口令、目录爆破、暗网泄露、Github泄露、文库网盘泄露、敏感信息泄露，其中资产收集必包含，多个用英文逗号隔离，例如：资产收集,漏洞信息</p>
        /// </summary>
        [JsonProperty("ScanType")]
        public string ScanType{ get; set; }

        /// <summary>
        /// <p>创建账号</p>
        /// </summary>
        [JsonProperty("Creator")]
        public string Creator{ get; set; }

        /// <summary>
        /// <p>腾讯云客户AppId</p>
        /// </summary>
        [JsonProperty("AppId")]
        public long? AppId{ get; set; }

        /// <summary>
        /// <p>腾讯云客户Uin</p>
        /// </summary>
        [JsonProperty("Uin")]
        public string Uin{ get; set; }

        /// <summary>
        /// <p>创建时间</p>
        /// </summary>
        [JsonProperty("CreateAt")]
        public string CreateAt{ get; set; }

        /// <summary>
        /// <p>更新时间</p>
        /// </summary>
        [JsonProperty("UpdateAt")]
        public string UpdateAt{ get; set; }

        /// <summary>
        /// <p>周期测绘时间</p>
        /// </summary>
        [JsonProperty("ScanCron")]
        public string ScanCron{ get; set; }

        /// <summary>
        /// <p>是否启用周期测绘</p>
        /// </summary>
        [JsonProperty("EnableCron")]
        public bool? EnableCron{ get; set; }

        /// <summary>
        /// <p>是否扫描子公司</p>
        /// </summary>
        [JsonProperty("EnableScanSubEnterprise")]
        public bool? EnableScanSubEnterprise{ get; set; }

        /// <summary>
        /// <p>是否授权</p>
        /// </summary>
        [JsonProperty("EnableAuth")]
        public bool? EnableAuth{ get; set; }

        /// <summary>
        /// <p>授权开始时间</p>
        /// </summary>
        [JsonProperty("AuthStartAt")]
        public string AuthStartAt{ get; set; }

        /// <summary>
        /// <p>授权结束时间</p>
        /// </summary>
        [JsonProperty("AuthEndAt")]
        public string AuthEndAt{ get; set; }

        /// <summary>
        /// <p>授权文件id</p>
        /// </summary>
        [JsonProperty("AuthFile")]
        public string AuthFile{ get; set; }

        /// <summary>
        /// <p>测绘时间配置项</p>
        /// </summary>
        [JsonProperty("ScanTime")]
        public string ScanTime{ get; set; }

        /// <summary>
        /// <p>图标</p>
        /// </summary>
        [JsonProperty("Icon")]
        public string Icon{ get; set; }

        /// <summary>
        /// <p>关键字</p>
        /// </summary>
        [JsonProperty("Keywords")]
        public string Keywords{ get; set; }

        /// <summary>
        /// <p>Qps设置，10-500，默认100</p>
        /// </summary>
        [JsonProperty("Qps")]
        public long? Qps{ get; set; }

        /// <summary>
        /// <p>子公司拓展层次</p>
        /// </summary>
        [JsonProperty("SubCompanyLevel")]
        public long? SubCompanyLevel{ get; set; }

        /// <summary>
        /// <p>是否包含完整扫描</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IsIncludeFullScan")]
        public bool? IsIncludeFullScan{ get; set; }

        /// <summary>
        /// <p>是否识别集团成员</p>
        /// </summary>
        [JsonProperty("EnableGroupMemberDiscovered")]
        public bool? EnableGroupMemberDiscovered{ get; set; }

        /// <summary>
        /// <p>单 IP 任务并发数，默认 1，下限 1，保守值 3，上限 10</p>
        /// </summary>
        [JsonProperty("SingleIPTaskLimit")]
        public long? SingleIPTaskLimit{ get; set; }

        /// <summary>
        /// <p>端口扫描 QPS，默认 100，下限 10，保守值 200，上限 5000</p>
        /// </summary>
        [JsonProperty("PortScanQps")]
        public long? PortScanQps{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Percent", this.Percent);
            this.SetParamSimple(map, prefix + "ScanType", this.ScanType);
            this.SetParamSimple(map, prefix + "Creator", this.Creator);
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "Uin", this.Uin);
            this.SetParamSimple(map, prefix + "CreateAt", this.CreateAt);
            this.SetParamSimple(map, prefix + "UpdateAt", this.UpdateAt);
            this.SetParamSimple(map, prefix + "ScanCron", this.ScanCron);
            this.SetParamSimple(map, prefix + "EnableCron", this.EnableCron);
            this.SetParamSimple(map, prefix + "EnableScanSubEnterprise", this.EnableScanSubEnterprise);
            this.SetParamSimple(map, prefix + "EnableAuth", this.EnableAuth);
            this.SetParamSimple(map, prefix + "AuthStartAt", this.AuthStartAt);
            this.SetParamSimple(map, prefix + "AuthEndAt", this.AuthEndAt);
            this.SetParamSimple(map, prefix + "AuthFile", this.AuthFile);
            this.SetParamSimple(map, prefix + "ScanTime", this.ScanTime);
            this.SetParamSimple(map, prefix + "Icon", this.Icon);
            this.SetParamSimple(map, prefix + "Keywords", this.Keywords);
            this.SetParamSimple(map, prefix + "Qps", this.Qps);
            this.SetParamSimple(map, prefix + "SubCompanyLevel", this.SubCompanyLevel);
            this.SetParamSimple(map, prefix + "IsIncludeFullScan", this.IsIncludeFullScan);
            this.SetParamSimple(map, prefix + "EnableGroupMemberDiscovered", this.EnableGroupMemberDiscovered);
            this.SetParamSimple(map, prefix + "SingleIPTaskLimit", this.SingleIPTaskLimit);
            this.SetParamSimple(map, prefix + "PortScanQps", this.PortScanQps);
        }
    }
}

