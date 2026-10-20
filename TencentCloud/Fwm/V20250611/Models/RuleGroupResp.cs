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

namespace TencentCloud.Fwm.V20250611.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RuleGroupResp : AbstractModel
    {
        
        /// <summary>
        /// 租户Id
        /// </summary>
        [JsonProperty("AppId")]
        public string AppId{ get; set; }

        /// <summary>
        /// 规则组Id
        /// </summary>
        [JsonProperty("GroupId")]
        public string GroupId{ get; set; }

        /// <summary>
        /// 规则组名称
        /// </summary>
        [JsonProperty("GroupName")]
        public string GroupName{ get; set; }

        /// <summary>
        /// 规则数量
        /// </summary>
        [JsonProperty("RuleCount")]
        public long? RuleCount{ get; set; }

        /// <summary>
        /// 产品类型
        /// </summary>
        [JsonProperty("Product")]
        public string Product{ get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// 创建人SubUin
        /// </summary>
        [JsonProperty("CreateBy")]
        public string CreateBy{ get; set; }

        /// <summary>
        /// 创建人名称
        /// </summary>
        [JsonProperty("CreateName")]
        public string CreateName{ get; set; }

        /// <summary>
        /// 更新人SubUin
        /// </summary>
        [JsonProperty("UpdateBy")]
        public string UpdateBy{ get; set; }

        /// <summary>
        /// 更新人名称
        /// </summary>
        [JsonProperty("UpdateName")]
        public string UpdateName{ get; set; }

        /// <summary>
        /// 下发关联账号
        /// </summary>
        [JsonProperty("ReceiveAccount")]
        public ReceiveAccount[] ReceiveAccount{ get; set; }

        /// <summary>
        ///  所属阶段
        /// </summary>
        [JsonProperty("ExecAreas")]
        public string[] ExecAreas{ get; set; }

        /// <summary>
        /// 规则方向：1-入站规则，0-出站规则，-1 表示无方向
        /// </summary>
        [JsonProperty("Direction")]
        public long? Direction{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "GroupId", this.GroupId);
            this.SetParamSimple(map, prefix + "GroupName", this.GroupName);
            this.SetParamSimple(map, prefix + "RuleCount", this.RuleCount);
            this.SetParamSimple(map, prefix + "Product", this.Product);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "CreateBy", this.CreateBy);
            this.SetParamSimple(map, prefix + "CreateName", this.CreateName);
            this.SetParamSimple(map, prefix + "UpdateBy", this.UpdateBy);
            this.SetParamSimple(map, prefix + "UpdateName", this.UpdateName);
            this.SetParamArrayObj(map, prefix + "ReceiveAccount.", this.ReceiveAccount);
            this.SetParamArraySimple(map, prefix + "ExecAreas.", this.ExecAreas);
            this.SetParamSimple(map, prefix + "Direction", this.Direction);
        }
    }
}

