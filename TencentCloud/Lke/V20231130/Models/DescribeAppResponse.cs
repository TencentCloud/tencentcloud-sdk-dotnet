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

namespace TencentCloud.Lke.V20231130.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeAppResponse : AbstractModel
    {
        
        /// <summary>
        /// 应用 ID
        /// </summary>
        [JsonProperty("AppBizId")]
        public string AppBizId{ get; set; }

        /// <summary>
        /// 应用类型；knowledge_qa-知识问答管理；summary-知识摘要；classifys-知识标签提取
        /// </summary>
        [JsonProperty("AppType")]
        public string AppType{ get; set; }

        /// <summary>
        /// 应用类型说明
        /// </summary>
        [JsonProperty("AppTypeDesc")]
        public string AppTypeDesc{ get; set; }

        /// <summary>
        /// 应用类型说明
        /// </summary>
        [JsonProperty("BaseConfig")]
        public BaseConfig BaseConfig{ get; set; }

        /// <summary>
        /// 应用配置
        /// </summary>
        [JsonProperty("AppConfig")]
        public AppConfig AppConfig{ get; set; }

        /// <summary>
        /// 头像是否在申诉中
        /// </summary>
        [JsonProperty("AvatarInAppeal")]
        public bool? AvatarInAppeal{ get; set; }

        /// <summary>
        /// 角色描述是否在申诉中
        /// </summary>
        [JsonProperty("RoleInAppeal")]
        public bool? RoleInAppeal{ get; set; }

        /// <summary>
        /// 名称是否在申诉中
        /// </summary>
        [JsonProperty("NameInAppeal")]
        public bool? NameInAppeal{ get; set; }

        /// <summary>
        /// 欢迎语是否在申诉中
        /// </summary>
        [JsonProperty("GreetingInAppeal")]
        public bool? GreetingInAppeal{ get; set; }

        /// <summary>
        /// 未知问题回复语是否在申诉中
        /// </summary>
        [JsonProperty("BareAnswerInAppeal")]
        public bool? BareAnswerInAppeal{ get; set; }

        /// <summary>
        /// 应用appKey
        /// </summary>
        [JsonProperty("AppKey")]
        public string AppKey{ get; set; }

        /// <summary>
        /// 应用状态，1：未上线，2：运行中，3：停用
        /// </summary>
        [JsonProperty("AppStatus")]
        public ulong? AppStatus{ get; set; }

        /// <summary>
        /// 状态说明
        /// </summary>
        [JsonProperty("AppStatusDesc")]
        public string AppStatusDesc{ get; set; }

        /// <summary>
        /// 应用是否在复制中
        /// </summary>
        [JsonProperty("IsCopying")]
        public bool? IsCopying{ get; set; }

        /// <summary>
        /// 唯一请求 ID，由服务端生成，每次请求都会返回（若请求因其他原因未能抵达服务端，则该次请求不会获得 RequestId）。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AppBizId", this.AppBizId);
            this.SetParamSimple(map, prefix + "AppType", this.AppType);
            this.SetParamSimple(map, prefix + "AppTypeDesc", this.AppTypeDesc);
            this.SetParamObj(map, prefix + "BaseConfig.", this.BaseConfig);
            this.SetParamObj(map, prefix + "AppConfig.", this.AppConfig);
            this.SetParamSimple(map, prefix + "AvatarInAppeal", this.AvatarInAppeal);
            this.SetParamSimple(map, prefix + "RoleInAppeal", this.RoleInAppeal);
            this.SetParamSimple(map, prefix + "NameInAppeal", this.NameInAppeal);
            this.SetParamSimple(map, prefix + "GreetingInAppeal", this.GreetingInAppeal);
            this.SetParamSimple(map, prefix + "BareAnswerInAppeal", this.BareAnswerInAppeal);
            this.SetParamSimple(map, prefix + "AppKey", this.AppKey);
            this.SetParamSimple(map, prefix + "AppStatus", this.AppStatus);
            this.SetParamSimple(map, prefix + "AppStatusDesc", this.AppStatusDesc);
            this.SetParamSimple(map, prefix + "IsCopying", this.IsCopying);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

