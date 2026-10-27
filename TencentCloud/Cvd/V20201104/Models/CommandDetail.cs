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

namespace TencentCloud.Cvd.V20201104.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CommandDetail : AbstractModel
    {
        
        /// <summary>
        /// 租户 Uin
        /// </summary>
        [JsonProperty("Uin")]
        public string Uin{ get; set; }

        /// <summary>
        /// 租户 APPID
        /// </summary>
        [JsonProperty("AppId")]
        public long? AppId{ get; set; }

        /// <summary>
        /// 任务类型，取值有：
        /// PowerShellScript
        /// Bat
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// RUNNING - 执行中；FINISHED - 执行完成
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 任务脚本，Base64 编码
        /// </summary>
        [JsonProperty("Command")]
        public string Command{ get; set; }

        /// <summary>
        /// 任务唯一 ID
        /// </summary>
        [JsonProperty("CommandId")]
        public string CommandId{ get; set; }

        /// <summary>
        /// 任务完成时间
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 任务完成时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FinishTime")]
        public string FinishTime{ get; set; }

        /// <summary>
        /// 各实例运行结果集
        /// </summary>
        [JsonProperty("Invocations")]
        public InvocationDetail[] Invocations{ get; set; }

        /// <summary>
        /// 是否以绑定用户运行任务，默认 false：system 用户执行
        /// </summary>
        [JsonProperty("RunAsBoundUser")]
        public bool? RunAsBoundUser{ get; set; }

        /// <summary>
        /// 是否前台运行任务，默认 false：后台运行任务
        /// </summary>
        [JsonProperty("RunForeground")]
        public bool? RunForeground{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Uin", this.Uin);
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "Command", this.Command);
            this.SetParamSimple(map, prefix + "CommandId", this.CommandId);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "FinishTime", this.FinishTime);
            this.SetParamArrayObj(map, prefix + "Invocations.", this.Invocations);
            this.SetParamSimple(map, prefix + "RunAsBoundUser", this.RunAsBoundUser);
            this.SetParamSimple(map, prefix + "RunForeground", this.RunForeground);
        }
    }
}

