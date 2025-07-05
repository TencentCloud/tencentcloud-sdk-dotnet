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

namespace TencentCloud.Cwp.V20180228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class BashPolicy : AbstractModel
    {
        
        /// <summary>
        /// 策略名称
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 1:有效 0:无效
        /// </summary>
        [JsonProperty("Enable")]
        public long? Enable{ get; set; }

        /// <summary>
        /// 0:黑名单 1:白名单
        /// </summary>
        [JsonProperty("White")]
        public long? White{ get; set; }

        /// <summary>
        /// 0:告警 1:白名单 2:拦截
        /// </summary>
        [JsonProperty("BashAction")]
        public long? BashAction{ get; set; }

        /// <summary>
        /// 正则表达式 base64 加密,该字段废弃,如果写入则自动替换为Rules.Process.CmdLine
        /// </summary>
        [JsonProperty("Rule")]
        public string Rule{ get; set; }

        /// <summary>
        /// 危险等级(0:无，1: 高危 2:中危 3: 低危)
        /// </summary>
        [JsonProperty("Level")]
        public long? Level{ get; set; }

        /// <summary>
        /// 生效范围（0:一组quuid 1:所有专业版(包含旗舰版) 2:所有旗舰版 3:所有主机）
        /// </summary>
        [JsonProperty("Scope")]
        public long? Scope{ get; set; }

        /// <summary>
        /// 策略ID
        /// </summary>
        [JsonProperty("Id")]
        public long? Id{ get; set; }

        /// <summary>
        /// 策略描述
        /// </summary>
        [JsonProperty("Descript")]
        public string Descript{ get; set; }

        /// <summary>
        /// 事件列表点击“加入白名单”时,需要传EventId 事件的id
        /// </summary>
        [JsonProperty("EventId")]
        public long? EventId{ get; set; }

        /// <summary>
        /// 是否处理旧事件为白名单 0=不处理 1=处理
        /// </summary>
        [JsonProperty("DealOldEvents")]
        public long? DealOldEvents{ get; set; }

        /// <summary>
        /// 生效主机的QUUID集合
        /// </summary>
        [JsonProperty("Quuids")]
        public string[] Quuids{ get; set; }

        /// <summary>
        /// 策略类型，0:系统  1:用户
        /// </summary>
        [JsonProperty("Category")]
        public long? Category{ get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        [JsonProperty("ModifyTime")]
        public string ModifyTime{ get; set; }

        /// <summary>
        /// 老版本兼容可能会用到
        /// </summary>
        [JsonProperty("Uuids")]
        public string[] Uuids{ get; set; }

        /// <summary>
        /// 规则表达式
        /// </summary>
        [JsonProperty("Rules")]
        public PolicyRules Rules{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Enable", this.Enable);
            this.SetParamSimple(map, prefix + "White", this.White);
            this.SetParamSimple(map, prefix + "BashAction", this.BashAction);
            this.SetParamSimple(map, prefix + "Rule", this.Rule);
            this.SetParamSimple(map, prefix + "Level", this.Level);
            this.SetParamSimple(map, prefix + "Scope", this.Scope);
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "Descript", this.Descript);
            this.SetParamSimple(map, prefix + "EventId", this.EventId);
            this.SetParamSimple(map, prefix + "DealOldEvents", this.DealOldEvents);
            this.SetParamArraySimple(map, prefix + "Quuids.", this.Quuids);
            this.SetParamSimple(map, prefix + "Category", this.Category);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "ModifyTime", this.ModifyTime);
            this.SetParamArraySimple(map, prefix + "Uuids.", this.Uuids);
            this.SetParamObj(map, prefix + "Rules.", this.Rules);
        }
    }
}

