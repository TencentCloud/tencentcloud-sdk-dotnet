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

namespace TencentCloud.Csip.V20221121.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ScanTaskInfoList : AbstractModel
    {
        
        /// <summary>
        /// 任务名称
        /// </summary>
        [JsonProperty("TaskName")]
        public string TaskName{ get; set; }

        /// <summary>
        /// 任务开始时间
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// 任务结束时间
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// cron格式
        /// </summary>
        [JsonProperty("ScanPlanContent")]
        public string ScanPlanContent{ get; set; }

        /// <summary>
        /// 0-周期任务,1-立即扫描,2-定时扫描,3-自定义
        /// </summary>
        [JsonProperty("TaskType")]
        public long? TaskType{ get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("InsertTime")]
        public string InsertTime{ get; set; }

        /// <summary>
        /// 任务ID
        /// </summary>
        [JsonProperty("TaskId")]
        public string TaskId{ get; set; }

        /// <summary>
        /// 自定义指定扫描资产信息
        /// </summary>
        [JsonProperty("SelfDefiningAssets")]
        public string[] SelfDefiningAssets{ get; set; }

        /// <summary>
        /// 预估时间
        /// </summary>
        [JsonProperty("PredictTime")]
        public long? PredictTime{ get; set; }

        /// <summary>
        /// 预估完成时间
        /// </summary>
        [JsonProperty("PredictEndTime")]
        public string PredictEndTime{ get; set; }

        /// <summary>
        /// 报告数量
        /// </summary>
        [JsonProperty("ReportNumber")]
        public long? ReportNumber{ get; set; }

        /// <summary>
        /// 资产数量
        /// </summary>
        [JsonProperty("AssetNumber")]
        public long? AssetNumber{ get; set; }

        /// <summary>
        /// 扫描状态, 0-初始值，1-正在扫描，2-扫描完成，3-扫描出错，4-停止扫描
        /// </summary>
        [JsonProperty("ScanStatus")]
        public long? ScanStatus{ get; set; }

        /// <summary>
        /// 任务进度
        /// </summary>
        [JsonProperty("Percent")]
        public float? Percent{ get; set; }

        /// <summary>
        /// port/poc/weakpass/webcontent/configrisk
        /// </summary>
        [JsonProperty("ScanItem")]
        public string ScanItem{ get; set; }

        /// <summary>
        /// 0-全扫，1-指定资产扫，2-排除资产扫，3-自定义指定资产扫描
        /// </summary>
        [JsonProperty("ScanAssetType")]
        public long? ScanAssetType{ get; set; }

        /// <summary>
        /// vss子任务id
        /// </summary>
        [JsonProperty("VSSTaskId")]
        public string VSSTaskId{ get; set; }

        /// <summary>
        /// cspm子任务id
        /// </summary>
        [JsonProperty("CSPMTaskId")]
        public string CSPMTaskId{ get; set; }

        /// <summary>
        /// 主机漏扫子任务id
        /// </summary>
        [JsonProperty("CWPPOCId")]
        public string CWPPOCId{ get; set; }

        /// <summary>
        /// 主机基线子任务id
        /// </summary>
        [JsonProperty("CWPBlId")]
        public string CWPBlId{ get; set; }

        /// <summary>
        /// vss子任务进度
        /// </summary>
        [JsonProperty("VSSTaskProcess")]
        public long? VSSTaskProcess{ get; set; }

        /// <summary>
        /// cspm子任务进度
        /// </summary>
        [JsonProperty("CSPMTaskProcess")]
        public ulong? CSPMTaskProcess{ get; set; }

        /// <summary>
        /// 主机漏扫子任务进度
        /// </summary>
        [JsonProperty("CWPPOCProcess")]
        public long? CWPPOCProcess{ get; set; }

        /// <summary>
        /// 主机基线子任务进度
        /// </summary>
        [JsonProperty("CWPBlProcess")]
        public ulong? CWPBlProcess{ get; set; }

        /// <summary>
        /// 异常状态码
        /// </summary>
        [JsonProperty("ErrorCode")]
        public long? ErrorCode{ get; set; }

        /// <summary>
        /// 异常信息
        /// </summary>
        [JsonProperty("ErrorInfo")]
        public string ErrorInfo{ get; set; }

        /// <summary>
        /// 周期任务开始的天数
        /// </summary>
        [JsonProperty("StartDay")]
        public long? StartDay{ get; set; }

        /// <summary>
        /// 扫描频率,单位天,1-每天,7-每周,30-月,0-扫描一次
        /// </summary>
        [JsonProperty("Frequency")]
        public long? Frequency{ get; set; }

        /// <summary>
        /// 完成次数
        /// </summary>
        [JsonProperty("CompleteNumber")]
        public long? CompleteNumber{ get; set; }

        /// <summary>
        /// 已完成资产个数
        /// </summary>
        [JsonProperty("CompleteAssetNumber")]
        public long? CompleteAssetNumber{ get; set; }

        /// <summary>
        /// 风险数
        /// </summary>
        [JsonProperty("RiskCount")]
        public long? RiskCount{ get; set; }

        /// <summary>
        /// 资产
        /// </summary>
        [JsonProperty("Assets")]
        public TaskAssetObject[] Assets{ get; set; }

        /// <summary>
        /// 用户Appid
        /// </summary>
        [JsonProperty("AppId")]
        public string AppId{ get; set; }

        /// <summary>
        /// 用户主账户ID
        /// </summary>
        [JsonProperty("UIN")]
        public string UIN{ get; set; }

        /// <summary>
        /// 用户名称
        /// </summary>
        [JsonProperty("UserName")]
        public string UserName{ get; set; }

        /// <summary>
        /// 体检模式，0-标准模式，1-快速模式，2-高级模式
        /// </summary>
        [JsonProperty("TaskMode")]
        public long? TaskMode{ get; set; }

        /// <summary>
        /// 扫描来源
        /// </summary>
        [JsonProperty("ScanFrom")]
        public string ScanFrom{ get; set; }

        /// <summary>
        /// 是否限免体检0不是，1是
        /// </summary>
        [JsonProperty("IsFree")]
        public long? IsFree{ get; set; }

        /// <summary>
        /// 是否可以删除，1-可以，0-不可以，对应多账户管理使用
        /// </summary>
        [JsonProperty("IsDelete")]
        public long? IsDelete{ get; set; }

        /// <summary>
        /// 任务源类型，0-默认，1-小助手，2-体检项
        /// </summary>
        [JsonProperty("SourceType")]
        public long? SourceType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TaskName", this.TaskName);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "ScanPlanContent", this.ScanPlanContent);
            this.SetParamSimple(map, prefix + "TaskType", this.TaskType);
            this.SetParamSimple(map, prefix + "InsertTime", this.InsertTime);
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamArraySimple(map, prefix + "SelfDefiningAssets.", this.SelfDefiningAssets);
            this.SetParamSimple(map, prefix + "PredictTime", this.PredictTime);
            this.SetParamSimple(map, prefix + "PredictEndTime", this.PredictEndTime);
            this.SetParamSimple(map, prefix + "ReportNumber", this.ReportNumber);
            this.SetParamSimple(map, prefix + "AssetNumber", this.AssetNumber);
            this.SetParamSimple(map, prefix + "ScanStatus", this.ScanStatus);
            this.SetParamSimple(map, prefix + "Percent", this.Percent);
            this.SetParamSimple(map, prefix + "ScanItem", this.ScanItem);
            this.SetParamSimple(map, prefix + "ScanAssetType", this.ScanAssetType);
            this.SetParamSimple(map, prefix + "VSSTaskId", this.VSSTaskId);
            this.SetParamSimple(map, prefix + "CSPMTaskId", this.CSPMTaskId);
            this.SetParamSimple(map, prefix + "CWPPOCId", this.CWPPOCId);
            this.SetParamSimple(map, prefix + "CWPBlId", this.CWPBlId);
            this.SetParamSimple(map, prefix + "VSSTaskProcess", this.VSSTaskProcess);
            this.SetParamSimple(map, prefix + "CSPMTaskProcess", this.CSPMTaskProcess);
            this.SetParamSimple(map, prefix + "CWPPOCProcess", this.CWPPOCProcess);
            this.SetParamSimple(map, prefix + "CWPBlProcess", this.CWPBlProcess);
            this.SetParamSimple(map, prefix + "ErrorCode", this.ErrorCode);
            this.SetParamSimple(map, prefix + "ErrorInfo", this.ErrorInfo);
            this.SetParamSimple(map, prefix + "StartDay", this.StartDay);
            this.SetParamSimple(map, prefix + "Frequency", this.Frequency);
            this.SetParamSimple(map, prefix + "CompleteNumber", this.CompleteNumber);
            this.SetParamSimple(map, prefix + "CompleteAssetNumber", this.CompleteAssetNumber);
            this.SetParamSimple(map, prefix + "RiskCount", this.RiskCount);
            this.SetParamArrayObj(map, prefix + "Assets.", this.Assets);
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "UIN", this.UIN);
            this.SetParamSimple(map, prefix + "UserName", this.UserName);
            this.SetParamSimple(map, prefix + "TaskMode", this.TaskMode);
            this.SetParamSimple(map, prefix + "ScanFrom", this.ScanFrom);
            this.SetParamSimple(map, prefix + "IsFree", this.IsFree);
            this.SetParamSimple(map, prefix + "IsDelete", this.IsDelete);
            this.SetParamSimple(map, prefix + "SourceType", this.SourceType);
        }
    }
}

