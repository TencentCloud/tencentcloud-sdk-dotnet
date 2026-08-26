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

    public class AccessKeyWhiteList : AbstractModel
    {
        
        /// <summary>
        /// 白名单ID
        /// </summary>
        [JsonProperty("ID")]
        public long? ID{ get; set; }

        /// <summary>
        /// 白名单策略名称
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// ak加白列表
        /// </summary>
        [JsonProperty("AKList")]
        public string[] AKList{ get; set; }

        /// <summary>
        /// ip加白列表
        /// </summary>
        [JsonProperty("IPList")]
        public string[] IPList{ get; set; }

        /// <summary>
        /// ip类型列表 IP类型 0:账号内（未备注） 1:账号外（未备注） 2:账号内 (已备注) 3:账号外 (已备注) 4:局域网（未备注）5:局域网（已备注）
        /// </summary>
        [JsonProperty("IPTypeList")]
        public long?[] IPTypeList{ get; set; }

        /// <summary>
        /// 接口加白列表
        /// </summary>
        [JsonProperty("ActionList")]
        public string[] ActionList{ get; set; }

        /// <summary>
        /// 调用方式加白
        /// 0 全部调用方式
        /// 1 控制台
        /// 2 API
        /// -1 不存在
        /// </summary>
        [JsonProperty("CallType")]
        public long? CallType{ get; set; }

        /// <summary>
        /// 错误码白名单（其他错误码待补充）
        /// 0 成功
        /// </summary>
        [JsonProperty("ErrorCodeList")]
        public long?[] ErrorCodeList{ get; set; }

        /// <summary>
        /// 策略内容/描述
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

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
        /// ak输入类型 
        /// 0:从现有选择
        /// 1:手动输入
        /// 2:临时密钥
        /// 3:长期密钥
        /// 4:全部密钥
        /// -1:无
        /// </summary>
        [JsonProperty("AkImportType")]
        public long? AkImportType{ get; set; }

        /// <summary>
        /// 主账号AppID
        /// </summary>
        [JsonProperty("AppID")]
        public ulong? AppID{ get; set; }

        /// <summary>
        /// 所属主账号uin
        /// </summary>
        [JsonProperty("Uin")]
        public string Uin{ get; set; }

        /// <summary>
        /// 所属主账号 昵称
        /// </summary>
        [JsonProperty("Nickname")]
        public string Nickname{ get; set; }

        /// <summary>
        /// 是否处理过去的告警
        /// </summary>
        [JsonProperty("NeedDealPastAlarm")]
        public bool? NeedDealPastAlarm{ get; set; }

        /// <summary>
        /// 处理状态
        /// 0 处理完成
        /// 1 正在处理
        /// </summary>
        [JsonProperty("DealStatus")]
        public long? DealStatus{ get; set; }

        /// <summary>
        /// 接口选择
        /// 0:自定义输入
        /// 1:产品+接口形式交互选择
        /// 2:全部接口
        /// </summary>
        [JsonProperty("ActionType")]
        public long? ActionType{ get; set; }

        /// <summary>
        /// 绑定策略id列表，为空代表全局生效
        /// </summary>
        [JsonProperty("AlarmPolicyID")]
        public long?[] AlarmPolicyID{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ID", this.ID);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamArraySimple(map, prefix + "AKList.", this.AKList);
            this.SetParamArraySimple(map, prefix + "IPList.", this.IPList);
            this.SetParamArraySimple(map, prefix + "IPTypeList.", this.IPTypeList);
            this.SetParamArraySimple(map, prefix + "ActionList.", this.ActionList);
            this.SetParamSimple(map, prefix + "CallType", this.CallType);
            this.SetParamArraySimple(map, prefix + "ErrorCodeList.", this.ErrorCodeList);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "AkImportType", this.AkImportType);
            this.SetParamSimple(map, prefix + "AppID", this.AppID);
            this.SetParamSimple(map, prefix + "Uin", this.Uin);
            this.SetParamSimple(map, prefix + "Nickname", this.Nickname);
            this.SetParamSimple(map, prefix + "NeedDealPastAlarm", this.NeedDealPastAlarm);
            this.SetParamSimple(map, prefix + "DealStatus", this.DealStatus);
            this.SetParamSimple(map, prefix + "ActionType", this.ActionType);
            this.SetParamArraySimple(map, prefix + "AlarmPolicyID.", this.AlarmPolicyID);
        }
    }
}

