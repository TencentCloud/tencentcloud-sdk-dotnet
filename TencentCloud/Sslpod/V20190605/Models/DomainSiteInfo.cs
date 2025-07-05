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

namespace TencentCloud.Sslpod.V20190605.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DomainSiteInfo : AbstractModel
    {
        
        /// <summary>
        /// ID标识
        /// </summary>
        [JsonProperty("Id")]
        public long? Id{ get; set; }

        /// <summary>
        /// 域名
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }

        /// <summary>
        /// IP地址
        /// </summary>
        [JsonProperty("Ip")]
        public string Ip{ get; set; }

        /// <summary>
        /// 是否自动获取IP：true：是，false:否
        /// </summary>
        [JsonProperty("AutoIP")]
        public bool? AutoIP{ get; set; }

        /// <summary>
        /// 评级
        /// "A+"，
        ///  "A"，
        /// "A-"，
        /// "B"，
        /// "C"，
        /// "D"，
        ///  "E"，
        ///  "F"，
        /// "T"，
        /// </summary>
        [JsonProperty("Grade")]
        public string Grade{ get; set; }

        /// <summary>
        /// 证书品牌
        /// </summary>
        [JsonProperty("Brand")]
        public string Brand{ get; set; }

        /// <summary>
        /// 监控服务类型
        /// 0 :Web
        /// 1: SMTP
        /// 2: IMAP
        /// 3: POP3
        /// </summary>
        [JsonProperty("ServerType")]
        public long? ServerType{ get; set; }

        /// <summary>
        /// 评级Code
        /// 0："unknown"，
        /// 1："A+"，
        /// 2： "A"，
        /// 3："A-"，
        /// 4："B"，
        /// 5："C"，
        /// 6："D"，
        /// 7： "E"，
        /// 8： "F"，
        /// 9："T"，
        /// </summary>
        [JsonProperty("GradeCode")]
        public long? GradeCode{ get; set; }

        /// <summary>
        /// 是否监控告警；true：是，false:否
        /// </summary>
        [JsonProperty("Notice")]
        public bool? Notice{ get; set; }

        /// <summary>
        /// 账号域名关系ID
        /// </summary>
        [JsonProperty("AccountDomainId")]
        public long? AccountDomainId{ get; set; }

        /// <summary>
        /// 标签
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Tags")]
        public string[] Tags{ get; set; }

        /// <summary>
        /// 域名状态:
        /// 连接异常，
        /// 证书已过期，
        /// 证书已吊销，
        /// 证书黑名单，
        /// 证书域名不匹配，
        /// 证书不可信，
        /// 证书密钥弱，
        /// 证书即将过期，少于7天，
        /// 证书即将过期，少于30天，
        /// 正常，
        /// 部分异常
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 域名端口
        /// </summary>
        [JsonProperty("Port")]
        public string Port{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
            this.SetParamSimple(map, prefix + "Ip", this.Ip);
            this.SetParamSimple(map, prefix + "AutoIP", this.AutoIP);
            this.SetParamSimple(map, prefix + "Grade", this.Grade);
            this.SetParamSimple(map, prefix + "Brand", this.Brand);
            this.SetParamSimple(map, prefix + "ServerType", this.ServerType);
            this.SetParamSimple(map, prefix + "GradeCode", this.GradeCode);
            this.SetParamSimple(map, prefix + "Notice", this.Notice);
            this.SetParamSimple(map, prefix + "AccountDomainId", this.AccountDomainId);
            this.SetParamArraySimple(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "Port", this.Port);
        }
    }
}

