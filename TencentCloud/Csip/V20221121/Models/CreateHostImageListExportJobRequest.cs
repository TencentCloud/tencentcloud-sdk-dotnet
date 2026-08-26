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

namespace TencentCloud.Csip.V20221121.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateHostImageListExportJobRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>集群CA证书MD5（32位十六进制，必填）</p>
        /// </summary>
        [JsonProperty("ClusterCaMD5")]
        public string ClusterCaMD5{ get; set; }

        /// <summary>
        /// <p>集团账号的成员id</p>
        /// </summary>
        [JsonProperty("MemberId")]
        public string[] MemberId{ get; set; }

        /// <summary>
        /// <p>通用ListFilter结构（含Filters数组 + ListFindOption分页）<br>支持的过滤字段：Host / ImageId / ImageName / HasRunningContainer</p>
        /// </summary>
        [JsonProperty("Filter")]
        public Filter Filter{ get; set; }

        /// <summary>
        /// <p>导出字段列表（不传则导出全部字段）<br>枚举值：<br>ImageId：镜像ID<br>ImageName：镜像名<br>ImageVersion：镜像版本<br>ContainerCount：关联容器数<br>HostCount：关联主机数<br>CreateTime：创建时间<br>NickName：所属账号昵称（单账号模式下自动排除）<br>ScanStatus：扫描状态<br>LastScanTime：最近扫描完成时间<br>VulCountCritical：critical级别漏洞数<br>VulCountHigh：high级别漏洞数<br>VulCountMedium：medium级别漏洞数<br>VulCountLow：low级别漏洞数<br>VirusCountCritical：critical级别木马数<br>VirusCountHigh：high级别木马数<br>VirusCountMedium：medium级别木马数<br>VirusCountLow：low级别木马数<br>SensitiveCountCritical：critical级别敏感信息数<br>SensitiveCountHigh：high级别敏感信息数<br>SensitiveCountMedium：medium级别敏感信息数<br>SensitiveCountLow：low级别敏感信息数</p>
        /// </summary>
        [JsonProperty("ExportFields")]
        public string[] ExportFields{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ClusterCaMD5", this.ClusterCaMD5);
            this.SetParamArraySimple(map, prefix + "MemberId.", this.MemberId);
            this.SetParamObj(map, prefix + "Filter.", this.Filter);
            this.SetParamArraySimple(map, prefix + "ExportFields.", this.ExportFields);
        }
    }
}

