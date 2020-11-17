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

namespace TencentCloud.Zj.V20190121.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class MmsInstanceInfo : AbstractModel
    {
        
        /// <summary>
        /// 彩信实例id
        /// </summary>
        [JsonProperty("InstanceId")]
        public long? InstanceId{ get; set; }

        /// <summary>
        /// 彩信实例名称
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// 状态是否通知
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// 实例审核状态信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("StatusInfo")]
        public MmsInstanceStateInfo[] StatusInfo{ get; set; }

        /// <summary>
        /// 业务码
        /// </summary>
        [JsonProperty("AppSubId")]
        public string AppSubId{ get; set; }

        /// <summary>
        /// 彩信标题
        /// </summary>
        [JsonProperty("Title")]
        public string Title{ get; set; }

        /// <summary>
        /// 签名
        /// </summary>
        [JsonProperty("Sign")]
        public string Sign{ get; set; }

        /// <summary>
        /// 彩信内容
        /// </summary>
        [JsonProperty("Contents")]
        public string Contents{ get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("CreatedAt")]
        public string CreatedAt{ get; set; }

        /// <summary>
        /// 样例配置的链接地址
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Urls")]
        public string[] Urls{ get; set; }

        /// <summary>
        /// 机型列表
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PhoneType")]
        public ulong?[] PhoneType{ get; set; }

        /// <summary>
        /// 普通参数序号数组
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CommonParams")]
        public ulong?[] CommonParams{ get; set; }

        /// <summary>
        /// 链接参数序号数组
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UrlParams")]
        public ulong?[] UrlParams{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "InstanceName", this.InstanceName);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamArrayObj(map, prefix + "StatusInfo.", this.StatusInfo);
            this.SetParamSimple(map, prefix + "AppSubId", this.AppSubId);
            this.SetParamSimple(map, prefix + "Title", this.Title);
            this.SetParamSimple(map, prefix + "Sign", this.Sign);
            this.SetParamSimple(map, prefix + "Contents", this.Contents);
            this.SetParamSimple(map, prefix + "CreatedAt", this.CreatedAt);
            this.SetParamArraySimple(map, prefix + "Urls.", this.Urls);
            this.SetParamArraySimple(map, prefix + "PhoneType.", this.PhoneType);
            this.SetParamArraySimple(map, prefix + "CommonParams.", this.CommonParams);
            this.SetParamArraySimple(map, prefix + "UrlParams.", this.UrlParams);
        }
    }
}

